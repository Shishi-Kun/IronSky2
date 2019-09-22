using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //public PlayerMovement movement;
    public float count = 0; 

    void onCollisionEnter(Collision collisionInfo){

        if(collisionInfo.collider.tag == "Obstacle"){
            //movement.enabled = false;
        }

   }

}