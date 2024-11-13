using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public Transform par;
    private bool isCol;
    private void Start()
    {
        //par.transform.DORotate(new Vector3(transform.rotation.x, transform.rotation.y, 70), 0.1f).SetLoops(2, LoopType.Yoyo);
    }
    public void Flip()
    {
        if (!isCol)
        {
            Debug.Log("Flip");
            //isCol = true;
            par.transform.DORotate(new Vector3(transform.rotation.x, transform.rotation.y, 70), 0.2f).SetLoops(1, LoopType.Yoyo);
        }
    }
    public void Update()
    {
        if (UnityEngine.Input.GetKeyDown(KeyCode.K)) 
        {
            Flip();
        }
    }
}
