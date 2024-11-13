using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    public GameObject endGamePanel;
    public GameObject inGamePanel;

    public TMP_Text coinsText;

    public TMP_Text winAmountText;

    private void Awake()
    {
        instance = this;
        ShowCoins();
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
        coinsText.text=PlayerPrefs.GetInt("Money").ToString();
    }
    public void ShowEndGame(string t)
    {
        endGamePanel.SetActive(true);
        inGamePanel.SetActive(false);
        winAmountText.text = t;
    }
}
