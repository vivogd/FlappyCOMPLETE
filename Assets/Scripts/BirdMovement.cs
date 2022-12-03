using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public Vector3 dir;
    public float gravity = 10f;
    public float terminalVelocity;
    public float verticalVelocity;


    void Update()
    {
        transform.position+=dir*Time.deltaTime; 
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += Vector3.up;
        }

        ApplyGravity();
    }


    void ApplyGravity()
    {

    }
}
