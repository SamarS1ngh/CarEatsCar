using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IfDestroyed : MonoBehaviour
{
    public GameObject targetObject;
    public string sceneName;

    private void Start()
    {

    }
    private void Update()
    {
        // Check if the targetObject is destroyed
        if (targetObject != null && !Object.Equals(targetObject, null))
        {
            Debug.Log("TargetObject is not destroyed!");
        }
        else
        {
            Debug.Log("efjnwjo");
                changeScene();
        }
    }
        public void changeScene()
        {
            SceneManager.LoadScene(sceneName);
        }
}



