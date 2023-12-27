using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    
    public float moveSpeed = 5F;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // float newX = transform.position.x - moveSpeed;
        // Vector3 pos = new Vector3(newX, transform.position.y, transform.position.z) * Time.deltaTime;
        // gameObject.transform.SetPositionAndRotation(pos, transform.rotation);

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        
    }


}
