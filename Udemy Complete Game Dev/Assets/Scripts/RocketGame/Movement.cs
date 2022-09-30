using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float thrustAmount = 1;
    [SerializeField] private float rotateAmount = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }


    void ProcessThrust()
    {
        
        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * thrustAmount * Time.deltaTime);
            // tämän voisi tehdä myös rb.AddRelativeForce(0,1,0);
        }


    }
    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rotation(rotateAmount);   
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Rotation(-rotateAmount);
        }
    }

    // thrustAmount muuttujan sisältö laitetaan nyt rotationThisFrame muuttujaan
    void Rotation(float rotationThisFrame)
    {
        rb.freezeRotation = true; // freeze rotation so we can manual rotate
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationThisFrame);
        rb.freezeRotation = false; // 
    }
}
