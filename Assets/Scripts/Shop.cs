using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int[] costs;

    public Button[] buttons;
    public void Buy(int num)
    {
        if (PlayerPrefs.GetInt("Money")>=costs[num])
        {
            PlayerPrefs.SetInt("CurrentSkin", num);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - costs[num]);
            buttons[num].interactable = false;
        }
    }
}
