using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject dataMenuUI;
    public GameObject gamePanelUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        gamePanelUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        gamePanelUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void DisplayDataPanel()
    {
        pauseMenuUI.SetActive(false);
        dataMenuUI.SetActive(true);
    }

    public void ReturnPause()
    {
        pauseMenuUI.SetActive(true);
        dataMenuUI.SetActive(false);
    }
}
