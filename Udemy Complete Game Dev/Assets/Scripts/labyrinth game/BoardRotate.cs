using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardRotate : MonoBehaviour
{
    [SerializeField] private float yRotate;
    [SerializeField] private float xRotate;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RotateBoard();

        
    }

    void RotateBoard()
    {
        yRotate = Input.GetAxis("Horizontal");
        xRotate = Input.GetAxis("Vertical");
        transform.Rotate(xRotate, 0, yRotate);
    }
}
