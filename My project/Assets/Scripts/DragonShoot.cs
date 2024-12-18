using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonShoot : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    float bulletSpeed = 25f;
    [SerializeField]
    float bulletLifetime = 2.0f;
    float timer = 0;
    [SerializeField]
    float shootDelay = 0.2f;
    GameObject player;
    [SerializeField]
    float shootDistance = 10;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //IF player gets within certain distance
        Vector3 shootDir = player.transform.position - transform.position;
        if (shootDir.magnitude < shootDistance && timer > shootDelay)
        {
            //shoot towards the player
            //spawn the bullet
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            //push the bullet towards the player
            shootDir.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir * bulletSpeed;
            //delay the next bullet
            timer = 0;
            Destroy(bullet, bulletLifetime);
        }
    }
}
