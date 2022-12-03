using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject treePrefab;
    public float timeInterval;
    public float offset;
 

    float timeCounter;
    bool isGameOn;

 

    // Update is called once per frame
    void Update()
    {
        if (isGameOn)
        {
            timeCounter += Time.deltaTime;
            if (timeCounter > timeInterval)
            {
                timeCounter = 0;
                SpawnTree();
            }
        }
      

    }

    void SpawnTree()
    {

        Vector3 treePos = transform.position + Vector3.up * Random.Range(-offset, offset);
        Instantiate(treePrefab, treePos, Quaternion.identity);
    }

    public void Pause()
    {
        isGameOn = false;
        TreeMovement[] trees = FindObjectsOfType<TreeMovement>();
        for (int i = 0; i < trees.Length; i++)
        {
            trees[i].Pause();
        }
    }
    public void Play()
    {
        // clear all trees;
        TreeMovement[] trees = FindObjectsOfType<TreeMovement>();
        for (int i = 0; i < trees.Length; i++)
        {
            Destroy(trees[i].gameObject);
        } 

        isGameOn = true;
    }

}
