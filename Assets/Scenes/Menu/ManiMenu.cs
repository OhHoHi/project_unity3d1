using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ManiMenu : MonoBehaviour
{
  public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
  public void QuitGame()
    {
        Debug.Log("QUIT!!!");
        Application.Quit();
    }

}
