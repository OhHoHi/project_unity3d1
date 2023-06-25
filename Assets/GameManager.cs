
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject winGameUI;
    public void GameWin()
    {
        Debug.Log("You Win!!!");
        winGameUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
