using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public float rotation = 75;

    private Rigidbody body;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        // movement
        Vector3 move = transform.forward * vertical * speed * Time.deltaTime;
        body.MovePosition(body.position + move);

        // rotation
        float turn = rotation * horizontal * Time.deltaTime;
        Quaternion eulerRotation = Quaternion.Euler(0, turn, 0);
        body.MoveRotation(body.rotation * eulerRotation); ;
    }
}
