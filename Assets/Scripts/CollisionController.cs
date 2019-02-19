using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public Rigidbody rb;
    public MovementController controller;

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Obstacle")
        {
            controller.enabled = false;
            rb.velocity *= 0;
        }
    }
}
