using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    bool isPaused = false;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            TogglePause();
        }
    }
    public void TogglePause()
    {
        if (isPaused == true)
        {
            //unpauses time
            Time.timeScale = 1.0f;

            //hides button when unpaused
            pauseUI.SetActive(false);

            isPaused = false;
        }
        else
        {
            //pauses time
            Time.timeScale = 0;
            pauseUI.SetActive(true);
            isPaused = true;
        }
        //isPaused = !isPaused;
    }
    public void Quit()
    {
        Application.Quit();
    }
}

