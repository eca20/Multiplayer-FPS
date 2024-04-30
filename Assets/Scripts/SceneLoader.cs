using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // The name of the scene to load
    public string sceneName;

    // Singleton instance
    private static SceneLoader instance;

    // Ensure only one instance of SceneLoader exists
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Keep the SceneLoader object persistent between scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate SceneLoader objects
        }
    }

    // Function to asynchronously load the scene
    public void LoadSceneAsync()
    {
        StartCoroutine(LoadSceneCoroutine());
    }

    private IEnumerator LoadSceneCoroutine()
    {
        // Start loading the scene asynchronously
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

        // Wait until the asynchronous loading is complete
        while (!asyncLoad.isDone)
        {
            // Check the progress of the loading operation
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f); // 0.9 is the completion value

            // You can display a loading progress bar or do other loading animations here if needed

            yield return null;
        }

        // Once loading is complete, switch to the newly loaded scene
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));

        // Unload the previous scene if needed
       // SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("DemoWallet"));
        GameObject objectToDisable = GameObject.Find("UIDocument");

        // Check if the object was found
        if (objectToDisable != null)
        {
            // Disable the object
            objectToDisable.SetActive(false);
        }
        else
        {
            Debug.LogWarning("Object with name " + objectToDisable.name + " not found.");
        }

    }

    // Get the singleton instance of SceneLoader
    public static SceneLoader GetInstance()
    {
        return instance;
    }

}
