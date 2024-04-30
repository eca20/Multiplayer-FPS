using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Characters.FirstPerson;

[RequireComponent(typeof(FirstPersonController))]
public class LobbyPanelOpener : MonoBehaviour
{
    public GameObject LobbyPanel;
    public GameObject HeartImage;
    public GameObject HealthSlider;

    private static ILogger logger = Debug.unityLogger;

    public bool isActive;

    void Start()
    {
        Debug.unityLogger.Log("Lobby panel is:" + LobbyPanel.activeSelf);
    }

    void Update()
    {
        isActive = LobbyPanel.activeSelf;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
           Debug.unityLogger.Log("Escape pressed!");
           Debug.unityLogger.Log("Lobby panel is:" + LobbyPanel.activeSelf);

           if(isActive)
           {
                LobbyPanel.SetActive(false);
                HeartImage.SetActive(true);
                HealthSlider.SetActive(true);
                Cursor.visible = true;

           }
           else
           {
                LobbyPanel.SetActive(true);
                HeartImage.SetActive(false);
                HealthSlider.SetActive(false);
                Cursor.visible = true;


           }
           Debug.unityLogger.Log("Lobby panel is now:" + LobbyPanel.activeSelf);

        }
    }
}
