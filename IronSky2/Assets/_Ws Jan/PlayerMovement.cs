using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 10;
    float tilt = 60;
    public PlayerMovement instance;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate ()
    {   

        if(Input.GetKey("up")){
             transform.Translate(0f, 0f, speed*Time.deltaTime);
             Debug.Log(speed.ToString());
        }

        if(Input.GetKey("down")){
             transform.Translate(0f, 0f, -speed*Time.deltaTime);
             Debug.Log(speed.ToString());
        }

        if(Input.GetKey("left")){
             transform.Translate(-speed*Time.deltaTime, 0f, 0f);
             Debug.Log(speed.ToString());
        }

        if(Input.GetKey("right")){
             transform.Translate(speed*Time.deltaTime, 0f, 0f);
             Debug.Log(speed.ToString());
        }


    }
}
