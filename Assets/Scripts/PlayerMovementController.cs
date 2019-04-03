using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

    public Rigidbody rb;
    public int fowardSpeed = 700;
    public int sideSpeed = 700;

    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideSpeed * Time.deltaTime, 0, 0);
        }
    }
}
