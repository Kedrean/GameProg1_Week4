using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    // Bullet game object
    public GameObject bullet;
    // Bullet spawn point
    public Transform bulletSpawnPoint;
    // Bullet speed
    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Button press command
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            // Declare game object as _bullet
            GameObject _bullet = Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            // Get rigidbody component
            Rigidbody rb = _bullet.GetComponent<Rigidbody>();
            // Set velocity of bullet
            rb.velocity = bulletSpawnPoint.forward * bulletSpeed;
            // Destroy bullet
            
        }
    }
}
