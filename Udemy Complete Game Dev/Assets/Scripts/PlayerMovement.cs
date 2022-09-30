using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float MoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
 
    }

    void PrintInstructions()
    {
        // Debug.Log("THESE ARE THE INSTRUCTIONS:");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float yValue = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        transform.Translate(xValue, 0, yValue);
    }
}
