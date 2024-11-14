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

    public void Translate()
    {
        for (int i = 0; i < portugales.Length; i++)
        {
            textBars[i].text = portugales[i];
        }
        isPortu = true;
    }
}
