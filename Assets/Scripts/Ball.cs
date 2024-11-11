using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;

    private void Update()
    {
        Debug.Log(rb.velocity);
        if (rb.velocity.y<-10)
        {
            rb.velocity=new Vector3(rb.velocity.x,-10,rb.velocity.z);
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
        Debug.Log("Forced");
    }
}
