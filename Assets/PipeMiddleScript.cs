using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{


    public LogicScript logicScript;
    public BirdScript birdScript;

    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        birdScript = GameObject.FindGameObjectWithTag("Bird").GetComponent <BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.layer == 3 && birdScript.isAlive)
        {
            logicScript.AddScore(1);
        }
        
    }

}
