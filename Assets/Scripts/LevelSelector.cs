using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public Button[] buttons;
    private void OnEnable()
    {
        if (!PlayerPrefs.HasKey("Levels"))
        {
            PlayerPrefs.SetInt("Levels", 1);
        }
        foreach (var button in buttons)
        {
            button.interactable = false;
        }
        int f = PlayerPrefs.GetInt("Levels");
        for (int i = 0; i < f; i++)
        {
            buttons[i].interactable = true;
        }
    }
}
