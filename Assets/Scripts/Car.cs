using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 100f;
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
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(translation, 0, 0);
        transform.Rotate(0, rotation, 0);

    }

    void LateUpdate()
    {
        cam.transform.position = transform.position - camOffset;
    }
}
