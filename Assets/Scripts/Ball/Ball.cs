using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;

    public void MoveBall(Vector3 direction,float delta)
    {
        direction.y = 0;
        rb.MovePosition(transform.position+(direction*speed*delta));
    }
    public void ForceBall(Vector3 forceVector,float forcePower)
    {
        rb.AddForce(forcePower * forceVector);
        Debug.Log("Forced");
    }
}
