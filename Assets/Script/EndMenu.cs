using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public static bool GamePaused = false;

    public GameObject pausedUI;
    public GameObject failedUI;
    public GameObject winUI;
    public static EndMenu instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            Resume();
        }
    }
    private void Start()
    {
        pausedUI.SetActive(false);
        failedUI.SetActive(false);
        winUI.SetActive(false);

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    public void Resume()
    {
        pausedUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
        Debug.Log($"Resuming Game...");
    }

    void Paused()
    {
        pausedUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
        Debug.Log($"Pausing Game...");
    }

    public void Restart()
    {
        Debug.Log($"Restarting Game...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Resume();
    }

    public void Exit()
    {
        Debug.Log($"Exiting Game...");
        Application.Quit();
    }
}
