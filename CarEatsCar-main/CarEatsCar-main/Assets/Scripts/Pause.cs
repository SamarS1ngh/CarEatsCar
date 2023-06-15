using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public Button pauseButton;

    private bool isPaused = false;

    private void Start()
    {
        // Attach the OnClick event handler to the button
        pauseButton.onClick.AddListener(TogglePause);
    }

    private void TogglePause()
    {
        if (isPaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0f;
        isPaused = true;
        Debug.Log("Game Paused");
    }

    private void ResumeGame()
    {
        Time.timeScale = 1f;
        isPaused = false;
        Debug.Log("Game Resumed");
    }

}
