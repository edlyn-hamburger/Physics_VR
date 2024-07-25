using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public GameObject projectilePrefab; // Assign your projectile prefab in the inspector
    public Transform firePoint; // Assign the point from where the projectile will be fired
    public float projectileSpeed = 10f; // Set the speed of the projectile

    void Update()
    {
        // Check if the "F" key is pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            Fire();
        }
    }

    void Fire()
    {
        // Instantiate the projectile at the fire point
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        // Get the Rigidbody component of the projectile
        Rigidbody rb = projectile.GetComponent<Rigidbody>();

        // Set the velocity of the projectile
        rb.velocity = firePoint.forward * projectileSpeed;

        // Add a Projectile script to handle the collision
        projectile.AddComponent<Projectile>();
    }
}

public class Projectile : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Destroy the projectile when it collides with any object
        Destroy(gameObject);
    }
}