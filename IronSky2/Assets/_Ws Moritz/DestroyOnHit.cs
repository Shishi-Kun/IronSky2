using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnHit : MonoBehaviour
{

    void OnCollisionEnter (Collision col)
    {
        Destroy(gameObject);
    }
}