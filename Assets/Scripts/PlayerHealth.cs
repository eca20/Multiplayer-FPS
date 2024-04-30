using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Rpc;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using Ajuna.NetWallet;
using Photon.Pun;
using System;
using System.Collections;
using System.Net.Http;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using Schnorrkel.Keys;
using SubstrateNET.NetApi.Generated;
using SubstrateNET.NetApi.Generated.Model.sp_core.crypto;
using SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress;
using SubstrateNET.NetApi.Generated.Storage;
using SubstrateNET.RestClient;
using Random = System.Random;
using StreamJsonRpc;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using TMPro;


[RequireComponent(typeof(FirstPersonController))]
[RequireComponent(typeof(Rigidbody))]

public class PlayerHealth : MonoBehaviourPunCallbacks, IPunObservable {

    public MiniSecret MiniSecretAlice => new MiniSecret(Utils.HexToByteArray("0xe5be9a5092b81bca64be81d212e7f2f9eba183bb7a90954f7b76361f6edb5c0a"), ExpandMode.Ed25519);
    public Account Alice => Account.Build(KeyType.Sr25519, MiniSecretAlice.ExpandToSecret().ToBytes(), MiniSecretAlice.GetPair().Public.Key);
    public MiniSecret MiniSecretBob => new MiniSecret(Utils.HexToByteArray("0x398f0c28f98885e046333d4a41c19cee4c37368a9832c6502f6cfd182e2aef89"), ExpandMode.Ed25519);
    public Account Bob => Account.Build(KeyType.Sr25519, MiniSecretBob.ExpandToSecret().ToBytes(), MiniSecretAlice.GetPair().Public.Key);
    public string NodeUrl = "ws://127.0.0.1:9944";
    private SubstrateClientExt _client;

    public SubstrateClientExt Client => _client;

    private Random _random;

    private HttpClient _httpClient;

    private Client _serviceClient;

    private string _mnemonicSeed;

    private Hash _currentBlockHash, _finalBlockHash;

    private BlockData _currentBlockData, _finalBlockData;
    public delegate void Respawn(float time);
    public delegate void AddMessage(string Message);
    public event Respawn RespawnEvent;
    public event AddMessage AddMessageEvent;
    public bool IsPooling = false;

    private Wallet _wallet;
    public bool IsConnected => Client.IsConnected;
    public Account Account => _wallet.Account;

    public TextMeshProUGUI txtBlockNumber, txtPeers, txtName;

    public TextMeshProUGUI txtWalletName, txtWalletAddress, txtWalletBalance, txtWalletState;

    [SerializeField]
    private int startingHealth = 100;
    [SerializeField]
    private float sinkSpeed = 0.12f;
    [SerializeField]
    private float sinkTime = 2.5f;
    [SerializeField]
    private float respawnTime = 8.0f;
    [SerializeField]
    private AudioClip deathClip;
    [SerializeField]
    private AudioClip hurtClip;
    [SerializeField]
    private AudioSource playerAudio;
    [SerializeField]
    private float flashSpeed = 2f;
    [SerializeField]
    private Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    [SerializeField]
    private NameTag nameTag;
    [SerializeField]
    private Animator animator;

    private FirstPersonController fpController;
    private IKControl ikControl;
    private Slider healthSlider;
    private Image damageImage;
    private int currentHealth;
    private bool isDead;
    private bool isSinking;
    private bool damaged;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start() {
        fpController = GetComponent<FirstPersonController>();
        ikControl = GetComponentInChildren<IKControl>();
        damageImage = GameObject.FindGameObjectWithTag("Screen").transform.Find("DamageImage").GetComponent<Image>();
        healthSlider = GameObject.FindGameObjectWithTag("Screen").GetComponentInChildren<Slider>();
        currentHealth = startingHealth;
        if (photonView.IsMine) {
            gameObject.layer = LayerMask.NameToLayer("FPSPlayer");
            healthSlider.value = currentHealth;
        }
        damaged = false;
        isDead = false;
        isSinking = false;
        _random = new Random();

        _client = new SubstrateClientExt(new Uri(NodeUrl));

        txtBlockNumber.text = "0<#557190>/0";
        _currentBlockHash = null;
        _currentBlockData = null;
        _finalBlockHash = null;
        _finalBlockData = null;
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update() {
        if (damaged) {
            damaged = false;
            damageImage.color = flashColour;
        } else {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        if (isSinking) {
            transform.Translate(UnityEngine.Vector3.down * sinkSpeed * Time.deltaTime);
        }
    }

    /// <summary>
    /// RPC function to let the player take damage.
    /// </summary>
    /// <param name="amount">Amount of damage dealt.</param>
    /// <param name="enemyName">Enemy's name who cause this player's death.</param>
    [PunRPC]
    public void TakeDamage(int amount, string enemyName) {
        if (isDead) return;
        if (photonView.IsMine) {
            damaged = true;
            currentHealth -= amount;
            if (currentHealth <= 0) {
                photonView.RPC("Death", RpcTarget.All, enemyName);
            }
            healthSlider.value = currentHealth;
            animator.SetTrigger("IsHurt");
        }
        playerAudio.clip = hurtClip;
        playerAudio.Play();
    }

    /// <summary>
    /// RPC function to declare death of player.
    /// </summary>
    /// <param name="enemyName">Enemy's name who cause this player's death.</param>
    [PunRPC]
    void Death(string enemyName) {
        isDead = true;
        ikControl.enabled = false;
        nameTag.gameObject.SetActive(false);
        if (photonView.IsMine) {
            fpController.enabled = false;
            animator.SetTrigger("IsDead");
            AddMessageEvent(PhotonNetwork.LocalPlayer.NickName + " was killed by " + enemyName + "!");
            RespawnEvent(respawnTime);
            StartCoroutine("DestoryPlayer", respawnTime);
        }
        TransferBalance(this.Alice, this.Bob, 1000);
        playerAudio.clip = deathClip;
        playerAudio.Play();
        StartCoroutine("StartSinking", sinkTime);
    }

    /// <summary>
    /// Coroutine function to destory player game object.
    /// </summary>
    /// <param name="delayTime">Delay time before destory.</param>
    IEnumerator DestoryPlayer(float delayTime) {
        yield return new WaitForSeconds(delayTime);
        PhotonNetwork.Destroy(gameObject);
    }

    /// <summary>
    /// RPC function to start sinking the player game object.
    /// </summary>
    /// <param name="delayTime">Delay time before start sinking.</param>
    IEnumerator StartSinking(float delayTime) {
        yield return new WaitForSeconds(delayTime);
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
        rigidbody.isKinematic = false;
        isSinking = true;
    }

    /// <summary>
    /// Used to customize synchronization of variables in a script watched by a photon network view.
    /// </summary>
    /// <param name="stream">The network bit stream.</param>
    /// <param name="info">The network message information.</param>
    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) {
        if (stream.IsWriting) {
            stream.SendNext(currentHealth);
        } else {
            currentHealth = (int)stream.ReceiveNext();
        }
    }

     public async void TransferBalance(Account senderAccount,Account recipientAccount,  long amount)
        {
            if (!Client.IsConnected)
            {
                Debug.Log("Not connected!");
            }

            var transferRecipient = new AccountId32();
            transferRecipient.Create(recipientAccount.Bytes);

            var multiAddress = new EnumMultiAddress();
            multiAddress.Create(MultiAddress.Id, transferRecipient);

            var baseCampactU128 = new BaseCom<U128>();
            baseCampactU128.Create(amount);

            var transferKeepAlive = BalancesCalls.TransferKeepAlive(multiAddress, baseCampactU128);

            try
            {
                await Client.Author.SubmitAndWatchExtrinsicAsync(
                    OnExtrinsicStateUpdateEvent,
                    transferKeepAlive,
                    senderAccount, new ChargeAssetTxPayment(0, 0), 64, CancellationToken.None).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                var errorMessage = "An error occured";

                if (ex is RemoteInvocationException)
                {
                    errorMessage = ((RemoteInvocationException) ex).Message;
                }

                UnityMainThreadDispatcher.DispatchAsync(() =>
                {
                    txtWalletState.text = errorMessage;
                    txtWalletState.color = Color.red;
                    txtWalletState.fontSize = 40;
                });
            }

        }

         /// <summary>
    /// Callback sent together with the extrinsic
    /// </summary>
    /// <param name="subscriptionId"></param>
    /// <param name="extrinsicStatus"></param>
    private void OnExtrinsicStateUpdateEvent(string subscriptionId, ExtrinsicStatus extrinsicStatus)
    {
        var state = "Unknown";

        switch (extrinsicStatus.ExtrinsicState)
        {
            case ExtrinsicState.None:
                if (extrinsicStatus.InBlock?.Value.Length > 0)
                {
                    state = "InBlock";
                }
                else if (extrinsicStatus.Finalized?.Value.Length > 0)
                {
                    state = "Finalized";
                }
                else
                {
                    state = "None";
                }
                break;

            case ExtrinsicState.Future:
                state = "Future";
                break;

            case ExtrinsicState.Ready:
                state = "Ready";
                break;

            case ExtrinsicState.Dropped:
                state = "Dropped";
                break;

            case ExtrinsicState.Invalid:
                state = "Invalid";
                break;
        }

        UnityMainThreadDispatcher.DispatchAsync(() =>
        {
            txtWalletState.text = state;
            txtWalletState.color = Color.black;
            txtWalletState.fontSize = 40;
            Debug.Log("Font Size: " + txtWalletState.fontSize);
      
        });
    }

}
