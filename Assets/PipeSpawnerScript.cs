using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 3.0f;
    
    private float timer = 0;
    private System.Random rand = new System.Random();
    private List<GameObject> pipes = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
      
        SpawnPipe();
        
    }

    // Update is called once per frame
    void Update()
    {

        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            SpawnPipe();
            timer = 0;
        }

        CheckFirstClone();

    }

    void SpawnPipe()
    {
        float yPos = rand.Next(-9, 9);
        Vector3 newPos = new Vector3(transform.position.x, yPos, transform.position.z);
        GameObject clone = Instantiate(pipe, newPos, transform.rotation);
        pipes.Add(clone);
    }

    void CheckFirstClone()
    {
        GameObject curClone = pipes[0];
        if(curClone.transform.position.x < -30)
        {
            pipes.Remove(curClone);
            Destroy(curClone);
        }
    }

}
