using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    private Rigidbody[] bodies;
    private float speed = .5f;

    void Start()
    {
        bodies = GetComponentsInChildren<Rigidbody>(true);
    }

    void FixedUpdate()
    {
        foreach (var body in bodies)
        {
            body.MovePosition(body.position + new Vector3(0, 0, -speed));
        }
    }
}
