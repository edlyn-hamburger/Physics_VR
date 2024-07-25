using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Prefab to spawn
    public GameObject prefab;

    // Position to spawn the prefab
    public Vector3 spawnPosition;

    // Key to press for spawning the prefab
    public KeyCode spawnKey = KeyCode.Space;

    // Key to press for making the last spawned object float
    public KeyCode floatKey = KeyCode.G;

    // List to store references to spawned objects
    private List<GameObject> spawnedObjects = new List<GameObject>();

    // Floating force
    public float floatForce = 5f;

    void Update()
    {
        // Check if the spawn key is pressed
        if (Input.GetKeyDown(spawnKey))
        {
            // Spawn the prefab at the specified position
            GameObject spawnedObject = Instantiate(prefab, spawnPosition, Quaternion.identity);

            // Add the spawned object to the list
            spawnedObjects.Add(spawnedObject);
        }

        // Example: Making the last spawned object float
        if (Input.GetKeyDown(floatKey))
        {
            // Check if there's at least one spawned object
            if (spawnedObjects.Count > 0)
            {
                // Grab the last spawned object (most recent)
                GameObject lastSpawned = spawnedObjects[spawnedObjects.Count - 1];

                // Get the Rigidbody component of the last spawned object
                Rigidbody rb = lastSpawned.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    // Apply an upward force to make it float
                    rb.AddForce(Vector3.up * floatForce, ForceMode.Impulse);
                }
            }
        }
    }
}
