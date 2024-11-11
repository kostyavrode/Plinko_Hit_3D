using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public TMP_Text coinsText;

    private void Awake()
    {
        instance = this;
    }
    public void StartGame()
    {
        //
    }
    public void ExitApp()
    {
        Application.Quit();
    }
    public void ShowCoins()
    {

    }
}
