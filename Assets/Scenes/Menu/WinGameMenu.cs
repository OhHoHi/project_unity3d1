using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGameMenu : MonoBehaviour
{
    public static bool GameIsPause = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
  
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");

    }
    public void QuitGamw()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void Restarts()
    {
        SceneManager.LoadScene("Scene_real");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
