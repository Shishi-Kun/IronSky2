using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb;
    float speed = 10;
    float tilt = 60;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate ()
    {   

        if(Input.GetKey("up")){
             transform.Translate(speed*Time.deltaTime, 0f, 0f);
        }

        if(Input.GetKey("down")){
             transform.Translate(-speed*Time.deltaTime, 0f, 0f);
        }

        if(Input.GetKey("left")){
             transform.Translate(0f, 0f, speed*Time.deltaTime);
        }

        if(Input.GetKey("right")){
             transform.Translate(0f, 0f, -speed*Time.deltaTime);
        }


    }
}
