using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    public GameObject item;
    public int score;

    void Start(){

    }

    void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Power up picked up!");
        if(other.CompareTag("Player") || other.CompareTag("Bullet"))
        {
            PickUp();
        }

    }

    void PickUp()
    {
        Debug.Log("Power up picked up!");
        Destroy(item);
        Debug.Log(score);
        score = int.Parse(GameObject.Find("ScoreNum").GetComponent<UnityEngine.UI.Text>().text);
        score++;
        GameObject.Find("ScoreNum").GetComponent<UnityEngine.UI.Text>().text = score.ToString();
        //player.speed += 20f;
    }

}
