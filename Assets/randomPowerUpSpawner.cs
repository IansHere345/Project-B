using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;
using System.Collections.Generic;

public class randomPowerUpSpawner : MonoBehaviour
{
    public float minXSpawn = -18f;
    public float maxXSpawn = 18f;
    public float minZSpawn = -3f;
    public float maxZSpawn = 18f;
    public float spawnInterval = 5f;
    public List<GameObject> powerUpPrefabs;

    void Start()
    {
        StartCoroutine(SpawnPowerUp());
    }
    IEnumerator SpawnPowerUp()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            float randomX = Random.Range(minXSpawn, maxXSpawn);
            float randomZ = Random.Range(minZSpawn, maxZSpawn);
            Vector3 spawnPosition = new Vector3(randomX, 1.5f, randomZ);
            if (powerUpPrefabs.Count == 0)
            {
                continue;
            }
            int randomIndex = Random.Range(0, powerUpPrefabs.Count);
            Instantiate(powerUpPrefabs[randomIndex], spawnPosition, Quaternion.identity);
        }
    }
}
