using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float xRotator;
    [SerializeField] private float yRotator;
    [SerializeField] private float zRotator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotator, yRotator, zRotator);
    }
}
