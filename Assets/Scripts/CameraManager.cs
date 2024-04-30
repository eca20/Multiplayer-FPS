using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraManager : MonoBehaviour
{

    // Singleton instance
    private static CameraManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject); // Keep the SceneLoader object persistent between scenes
        }
        else
        {
            Destroy(this.gameObject); // Destroy duplicate SceneLoader objects
        }    }

    void OnEnable()
    {
        // Subscribe to the sceneLoaded event
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        // Unsubscribe from the sceneLoaded event
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Find the main camera in the newly loaded scene
        Camera mainCamera = Camera.main;

        if (mainCamera != null)
        {
            // Set the main camera as the active camera
            mainCamera.gameObject.SetActive(true);

            // Optionally, you can set the position and rotation of the camera as needed
            // For example:
               mainCamera.transform.position = new Vector3(-47, 29, -50); // Set camera position
            // mainCamera.transform.rotation = Quaternion.identity; // Set camera rotation (identity rotation)
        }
        else
        {
            Debug.LogWarning("Main camera not found in the newly loaded scene.");
        }
    }
}
