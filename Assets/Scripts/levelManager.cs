using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    public string sceneName;
    void start()
    {

    }

    void update()
    {

    }
    public void changeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
