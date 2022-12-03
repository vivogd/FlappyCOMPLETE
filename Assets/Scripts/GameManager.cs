using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public Bird bird;
    public GameObject myUI;
    public TreeSpawner treeSpawner;
    public Text scoreText;
    

    void Start()
    {
        Pause();
    }


    public void Play()
    {
        myUI.SetActive(false);
        bird.Play();
        treeSpawner.Play();
        score = 0;
        scoreText.text = score.ToString();
    }

    public void Pause()
    {
        myUI.SetActive(true);
        bird.Pause();
        treeSpawner.Pause();
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

  
}
