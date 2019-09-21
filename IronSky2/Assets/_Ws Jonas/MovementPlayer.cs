﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class MovementPlayer : MonoBehaviour {
    public Rigidbody rb;
    public GameObject player;
    public Animator animator;
    public float speed = 0f;
    public int rotation;
 
    public AudioSource bruellen, stampfen;

    void Start() {
        animator = GetComponent<Animator>();
        stampfen.Play();
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
            if (speed < 10) {
                speed++;
            }
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            if (speed > -5) {
                speed--;
            }
        } else {
            speed = 0f;
        }
        rb.AddForce(transform.forward * (speed / 10), ForceMode.Impulse);

        // Anhalten
        if (speed == 0f) {
            rb.velocity = new Vector3(0f, 0f, 0f);
            rb.angularVelocity = new Vector3(0f, 0f, 0f);
            stampfen.volume = 0f;
        } else {
            stampfen.volume = 0.3f;
        }

        animator.SetFloat("Speed", speed);
    }
}
