using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject UIDocument;
    private static ILogger logger = Debug.unityLogger;

    public bool isActive;

    // Singleton instance
    private static UIManager instance;

 void Start()
    {
        if(UIDocument == null){
            UIDocument = GameObject.Find("UIDocument");
        }
        logger.Log("UIDocument is:" + UIDocument.activeSelf);
    }

    void Update()
    {
        isActive = UIDocument.activeSelf;

        if (Input.GetKeyUp(KeyCode.Tab))
        {
           logger.Log("Tab pressed!");
           logger.Log("UIDocument is:" + UIDocument.activeSelf);

           if(isActive)
           {
                UIDocument.SetActive(false);
                Cursor.visible = false;
             //   isActive = false;
           }
           else
           {
                UIDocument.SetActive(true);
                Cursor.visible = true;
           //     isActive = true;
           }
           Debug.unityLogger.Log("UIDocument is now:" + UIDocument.activeSelf);
        }
    }

   // Get the singleton instance of SceneLoader
    public static UIManager GetInstance()
    {
        return instance;
    }
}
