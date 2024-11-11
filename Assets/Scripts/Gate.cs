using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] private int multiplier;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        Debug.Log("Game Ended +x"+multiplier.ToString());
        GameManager.instance.EndGame();
    }
}
