using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGamw : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter()
    {
        gameManager.GameWin();

    }
}
