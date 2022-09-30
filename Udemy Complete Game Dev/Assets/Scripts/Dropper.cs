using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rb;
    [SerializeField] float timetowait = 5f;

    private void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rb.useGravity = false;    
    }

    private void Update()
    {
        if(Time.time > timetowait)
        {
            renderer.enabled = true;
            rb.useGravity = true;
        }
    }

}

