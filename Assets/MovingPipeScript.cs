using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPipeScript : MonoBehaviour
{

    public float horizontalMoveSpeed = 5F;
    public float verticalMoveSpeed = 5F;
    public float shiftMax = 5F;
    private int counter = 0;
    private string shiftDirection = "UP";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Delta: " + Time.deltaTime);
        transform.position = transform.position + (Vector3.left * horizontalMoveSpeed) * Time.deltaTime;
        if(counter < shiftMax)
        {
            if(shiftDirection == "UP")
            {
                transform.position = transform.position + (Vector3.up * verticalMoveSpeed) * Time.deltaTime;
                Debug.Log("Moving up " + transform.position);
            } else
            {
                transform.position = transform.position + (Vector3.down * verticalMoveSpeed) * Time.deltaTime;
                Debug.Log("Moving down " + transform.position);
            }
            counter++;
            Debug.Log("counter " + counter);
        } else
        {
            counter = 0;
            shiftDirection = (shiftDirection == "UP") ? "DOWN" : "UP";
        }


    }
}
