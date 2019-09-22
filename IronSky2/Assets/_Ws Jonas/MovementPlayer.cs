using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class MovementPlayer : MonoBehaviour {
    public Rigidbody rb;
    public GameObject player;
    public Animator animator;
    public AudioSource bruellen, space;

    public float speed = 0f;
    public int rotation;

    void Start() {
        animator = GetComponent<Animator>();
        space.Play();
    }

    void FixedUpdate() {
        // Brüllen Sound
        if (Input.GetKey(KeyCode.Space)) {
            bruellen.Play();
        }

        // Drehung
        rotation = 0;
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rotation = rotation - 2;
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            rotation = rotation + 2;
        }  
        transform.Rotate(0, rotation, 0, Space.Self);

        // Vorwärts/Rückwärts
        if (Input.GetKey(KeyCode.UpArrow)) {
            speed = 10f;
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            speed = -5f;
        } else {
            speed = 0f;
        }
        rb.AddForce(transform.forward * (speed / 10), ForceMode.Impulse);

        // Anhalten
        if (speed == 0f) {
            rb.velocity = new Vector3(0f, 0f, 0f);
            rb.angularVelocity = new Vector3(0f, 0f, 0f);
        }

        animator.SetFloat("Speed", speed);
    }
}
