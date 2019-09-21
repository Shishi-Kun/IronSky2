using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class MovementPlayer : MonoBehaviour {
    public Rigidbody rb;
    public float speed = 0f;
    public int rotation;
 
    void FixedUpdate() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            if (speed < 100) {
                speed++;
            }
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            if (speed > -50) {
                speed = speed - 4f;
            }
        } else {
            speed = 0f;
        }

        if (speed == 0f) {
            rb.velocity = new Vector3(0f, 0f, 0f);
            rb.angularVelocity = new Vector3(0f, 0f, 0f);
        }

        rotation = 0;
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rotation = rotation - 2;
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            rotation = rotation + 2;
            
        }  

        transform.Rotate(0, rotation, 0, Space.Self);
        rb.AddForce(transform.forward * (speed / 10), ForceMode.Impulse);
    }
}
