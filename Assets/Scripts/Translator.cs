using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Translator : MonoBehaviour
{
    public static Translator instance;

    public bool isPortu;

    public string[] portugales;

    public TMP_Text[] textBars;

    private void Awake()
    {
        instance = this;
    }

    private void OnLevelWasLoaded(int level)
    {
        if (PlayerPrefs.GetInt("isPortu")==1)
        {
            Translate();
        }
    }

    public void Translate()
    {
        for (int i = 0; i < portugales.Length; i++)
        {
            textBars[i].text = portugales[i];
        }
        isPortu = true;
        PlayerPrefs.SetInt("isPortu", 1);
    }
}
