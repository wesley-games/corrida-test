using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshFollow : MonoBehaviour
{

    private WheelCollider wheel;

    void Start()
    {
        wheel = GetComponent<WheelCollider>();
    }

    void Update()
    {
        transform.position = wheel.transform.position;
        transform.rotation = wheel.transform.rotation;
    }
}
