using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    public string sceneName;
   
    public void changeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void title(){
        SceneManager.LoadScene("UI");
    }
}
