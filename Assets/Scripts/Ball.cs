using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private GameObject fx;
    private Sequence sequence;
    private void Update()
    {
        if (rb.velocity.y<-10)
        {
            rb.velocity=new Vector3(rb.velocity.x,-10,rb.velocity.z);
        }
        if (rb.velocity.y<-9.7f)
        {
            TurnFX();
        }
        else
        {
            TurnOffFX();
        }
    }

    public void MoveBall(Vector3 direction,float delta)
    {
        direction.y = 0;
        rb.MovePosition(transform.position+(direction*speed*delta));
        rb.velocity += direction*delta*speed;
    }
    public void ForceBall(Vector3 forceVector,float forcePower)
    {
        rb.AddForce(forcePower * forceVector);
    }
    private void TurnFX()
    {
        sequence.Kill();
        fx.transform.localScale = Vector3.zero;
        fx.SetActive(true);
        sequence.Append(fx.transform.DOScale(Vector3.one * 0.03f, 5f));
    }
    private void TurnOffFX()
    {
        sequence.Kill();
        sequence.Append(fx.transform.DOScale(Vector3.zero, 0.1f).OnComplete(() => 
        {
            fx.SetActive(false);
            sequence.Kill();
        }
        ));
    }
}
