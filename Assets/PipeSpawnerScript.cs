using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{

    public GameObject pipe;
    public GameObject movingPipe;
    public float spawnRate = 3.0f;
    
    private float timer = 0;
    private System.Random rand = new System.Random();
    private List<GameObject> pipes = new List<GameObject>();
    private int pipeType;

    // Start is called before the first frame update
    void Start()
    {
      
        pipes.Add(SpawnPipe(0));
        
    }

    // Update is called once per frame
    void Update()
    {

        // 0 is normal pipe, 1 is moving pipe
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            pipeType = rand.Next(0, 2);
            Debug.Log("Pipetype: " + pipeType);
            pipes.Add(SpawnPipe(pipeType));
            timer = 0;
        }

        CheckFirstClone();

    }

    GameObject SpawnPipe(int pipeType)
    {
        GameObject clone;
        float yPos = rand.Next(-9, 9);
        Vector3 newPos = new Vector3(transform.position.x, yPos, transform.position.z);
        if(pipeType == 0)
        {
            clone = Instantiate(pipe, newPos, transform.rotation);
        } else
        {
            Debug.Log("Moving Pipe");
            clone = Instantiate(movingPipe, newPos, transform.rotation);
        }

        return clone;
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
