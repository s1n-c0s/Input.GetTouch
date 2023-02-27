using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] items; // Array of item prefabs to spawn
    public float spawnRadius = 5f; // Radius around the spawner where items can be spawned
    public float spawnInterval = 1f; // Time between spawns
    public float destroyDelay = 10f; // Time before spawned items are destroyed

    private float timer = 0f; // Timer for tracking spawn interval

    void Update()
    {
        timer += Time.deltaTime;

        // Check if it's time to spawn a new item
        if (timer >= spawnInterval)
        {
            timer = 0f;

            // Choose a random item from the array
            int index = Random.Range(0, items.Length);
            GameObject itemPrefab = items[index];

            // Choose a random position on the XZ plane within the spawn radius
            Vector3 spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            spawnPosition.y = 0f; // Make sure the item is spawned at ground level

            // Spawn the item at the chosen position and parent it to the spawner
            GameObject newItem = Instantiate(itemPrefab, spawnPosition, Quaternion.identity);
            newItem.transform.parent = transform;

            // Schedule the spawned item to be destroyed after a delay
            Destroy(newItem, destroyDelay);
        }
    }
}
