using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = 10;
    public Camera cam;

    Rigidbody rb;
    Vector3 camOffset;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        camOffset = transform.position - cam.transform.position;
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moviment = new Vector3(horizontal, 0f, vertical);
        rb.AddForce(moviment * speed);
    }

    void LateUpdate()
    {
        cam.transform.position = transform.position - camOffset;
    }
}
