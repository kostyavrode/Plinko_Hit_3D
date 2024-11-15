using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float force;
    public Flipper flipper;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            if (flipper)
            {
                flipper.Flip();
            }
            collision.gameObject.GetComponent<Ball>().ForceBall(Vector3.up, force);
        }
    }
}
