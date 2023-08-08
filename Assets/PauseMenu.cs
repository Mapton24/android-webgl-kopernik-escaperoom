using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseMenuUI;
    [SerializeField]
    private GameObject gameCursor;
    private bool isPaused = false;
    //private bool cursorLocked = true;

    private void Start()
    {
        if (Cursor.lockState == CursorLockMode.None)
        {
            //cursorLocked = false;
        } else
        {
           // cursorLocked = true;
        }

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (isPaused)
            {
                Resume();
            } else if (!isPaused)
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        gameCursor.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
       // cursorLocked = true;
    }
    private void Pause()
    {
        pauseMenuUI.SetActive(true);
        gameCursor.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
       // cursorLocked = false;
    }
    public void Options()
    {

    }
    public void ExitMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneNames.MainMenu);
    }
}
