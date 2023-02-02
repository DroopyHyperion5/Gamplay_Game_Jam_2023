using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    public static bool GameIsPaused = false;

    public void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale= 0f;
        GameIsPaused= true;

    }

    public void Resume()
    {
        pausePanel.SetActive(false);
        Time.timeScale= 1f;
        GameIsPaused= false;   
    }

    public void Home(int sceneID)
    {
        Time.timeScale= 1f;
        SceneManager.LoadScene(sceneID);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        } 
    }
}
