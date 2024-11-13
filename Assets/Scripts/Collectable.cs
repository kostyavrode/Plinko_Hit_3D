using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private bool isCollectable=true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player" && isCollectable)
        {
            isCollectable=false;
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + 1);
            UIController.instance.ShowCoins();
            GetComponent<AnimationScript>().Blow(DestroyObject);
        }
    }
    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
