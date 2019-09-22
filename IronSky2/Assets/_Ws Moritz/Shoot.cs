using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject KugelPrefab;

    public float shootSpeed = 10000;
    private int bulletLifespan = 7; // in Sekunden
    private float fireRate = 0.4f;       // in Sekunden

    public Transform spawnPoint;

    private float nextFire;


    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            shootBullet();
        }
    }

    void shootBullet()
    {
        GameObject projectile;

        projectile = Instantiate(KugelPrefab, spawnPoint.position, transform.rotation);

        // Y ebene lock
        //projectile.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationY;

        // Schießen
        //projectile.GetComponent<Rigidbody>().velocity = Camera.main.transform.forward * shootSpeed;
        projectile.GetComponent<Rigidbody>().AddForce(this.transform.forward * shootSpeed, ForceMode.Impulse);


        // Zerstöre das Projektil nach bulletLifespan Sekunden
        Destroy(projectile, bulletLifespan);
    }
}