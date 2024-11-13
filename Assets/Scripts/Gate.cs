using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] private int multiplier;
    private bool isGameEnded;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        if (!isGameEnded)
        {
            Debug.Log("Game Ended +x" + multiplier.ToString());
            GameManager.instance.EndGame(multiplier);
            isGameEnded = true;
            PlayerPrefs.SetInt("Levels", PlayerPrefs.GetInt("Levels") + 1);
        }
    }
}
