using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input : MonoBehaviour
{
    public Joystick joystick;
    [SerializeField] private Ball ball;

    private void Update()
    {
        Vector3 dir= new Vector3(joystick.Horizontal,0,joystick.Vertical);
        ball.MoveBall(dir, Time.deltaTime);
    }
}
