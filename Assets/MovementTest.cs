using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    public float torque = 300f;
    public float steer = 30f;
    public float brake = 1000f;
    public WheelCollider[] torqueWheels;
    public WheelCollider[] steerWheels;

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        foreach (WheelCollider wheel in torqueWheels)
        {
            wheel.motorTorque = vertical * torque;
        }

        foreach (WheelCollider wheel in steerWheels)
        {
            wheel.steerAngle = horizontal * steer;
        }
    }
}
