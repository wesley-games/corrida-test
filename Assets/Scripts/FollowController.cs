using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void Start() 
    {
        this.offset = transform.position - target.position;
    }
    
    void Update()
    {
        transform.position = target.position + offset;
    }
}
