using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class BirdScript : MonoBehaviour
{


    public Rigidbody2D rigidBody;
    public float flapStrength;
    public LogicScript logicScript;
    public bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if(IsOutOfBounds())
        {
            GameOver();
        }
        else if(Input.GetKeyDown(KeyCode.Space) && isAlive) 
        {
            rigidBody.velocity = Vector2.up * flapStrength;

        } 
    }

    // collison since pipes are solid
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();

    }

    private bool IsOutOfBounds()
    {
        if(Math.Abs(gameObject.transform.position.x) > 30 || Math.Abs(gameObject.transform.position.y) > 18)
        {
            return true;
        }
        return false;
    }

    private void GameOver()
    {
        isAlive = false;
        logicScript.GameOver();
    }

}
