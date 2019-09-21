using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    public GameObject item;
    //public PlayerMovement move = PlayerMovement;
    public int count = 0;

    void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Power up picked up!");
        if(other.CompareTag("Player"))
        {
            PickUp();
        }

    }

    void PickUp()
    {
        Debug.Log("Power up picked up!");
        Destroy(item);
        //count ++;
        //move.instance.speed = 20;
    }

}
