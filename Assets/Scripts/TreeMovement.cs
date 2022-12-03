using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMovement : MonoBehaviour
{
    public float speed;
    bool isGameOn = true;
 
 
 
    void Update()
    {
        if (isGameOn)
        {
            transform.position += Vector3.back * speed * Time.deltaTime;

            if (transform.position.z < -15f)
            {
                Destroy(gameObject);
            }
        }
     
    }

    public void Pause()
    {
        isGameOn = false;
    }
}
