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

    void Update()
    {
        // Check if the spawn key is pressed
        if (Input.GetKeyDown(spawnKey))
        {
            // Spawn the prefab at the specified position
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }
}
