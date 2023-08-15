using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //[SerializeField]
    //private GameObject mainMenuHolder;
    //[SerializeField]
    //private GameObject optionsMenuHolder;

    private void Start()
    {
        // Unlock the cursor initially
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void Play()
    {
        if(Application.isEditor || Application.platform == RuntimePlatform.Android)
        {
            SceneManager.LoadScene(SceneNames.GameAndroid);
        }
        else
        {
            SceneManager.LoadScene(SceneNames.Game);
        }
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void Quit()
    {
        Application.Quit();
    }
    //public void OptionsMenu()
    //{
    //    mainMenuHolder.SetActive(false);
    //    optionsMenuHolder.SetActive(true);

    //}
    //public void MainMenu()
    //{
    //    optionsMenuHolder.SetActive(false);
    //    mainMenuHolder.SetActive(true);
    //}
}
