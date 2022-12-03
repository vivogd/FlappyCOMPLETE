using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float birdSpeed;
    public float flapPower;
    public float gravity;
    public Vector3 dir;
    public AudioClip flapSound;
    public AudioClip scoreSound;
    public AudioClip dieSound;

    public bool isGameOn;

    Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }
    void Update()
    {
        if (isGameOn)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                Flap();
            }

            dir.z = birdSpeed;
            dir.y += gravity * Time.deltaTime;
            transform.Translate(dir * Time.deltaTime);
        }

    }

    public void Pause()
    {
        isGameOn = false;
    }

    public void Play()
    {
        transform.position = startPos;
        dir.y = 0;
        isGameOn = true;
    }
    private void Flap()
    {
        dir = Vector3.up * flapPower;
        GetComponent<Animator>().SetTrigger("Flap");
        GetComponent<AudioSource>().PlayOneShot(flapSound);
    }

    private void Score()
    {
        GetComponent<AudioSource>().PlayOneShot(scoreSound);
        FindObjectOfType<GameManager>().AddScore();
    }
    
    private void Die()
    {
        GetComponent<AudioSource>().PlayOneShot(dieSound);
        FindObjectOfType<GameManager>().Pause();
    }



    private void ResetMe() 
    {

     

    }


    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Hit Collider " + collider.tag);
        if (collider.tag == "Ground" || collider.tag=="Tree")
        {
            Die();
        }
        else if (collider.tag == "Score")
        {
            Score();
        }
        ResetMe();
    }
}
