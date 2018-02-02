﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    public float torque = 1000f;
    public float steer = 30f;
    public float brake = 1000f;
    public WheelCollider[] torqueWheels;
    public WheelCollider[] steerWheels;
    public Rigidbody rb;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
    }

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

    public void OnGUI()
    {
        // foreach (WheelCollider wc in GetComponentsInChildren<WheelCollider>())
        // {
        //     GUILayout.Label(string.Format("{0} sprung: {1}, k: {2}, d: {3}", wc.name, wc.sprungMass, wc.suspensionSpring.spring, wc.suspensionSpring.damper));
        // }
        GUILayout.Label("Speed: " + rb.velocity);
    }
}