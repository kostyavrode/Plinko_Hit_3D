using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int score;
    private int score1;
    private void Awake()
    {
        instance = this;
    }

    private void OnEnable()
    {
        Time.timeScale = 1f;
    }
    public void StartGame()
    {
        score = PlayerPrefs.GetInt("Money");
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ContinueGame()
    {
        Time.timeScale = 1f;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void EndGame(int x)
    {
        score1= PlayerPrefs.GetInt("Money");
        int t=(score1-score)*x;
        UIController.instance.ShowEndGame(t.ToString());
        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + (t-(score1-score)));
    }
}
