using System.Collections;
using UnityEngine;

public class AlienDestroyer : MonoBehaviour
{
    [SerializeField] private GameObject RightmeteorPrefab; 
    [SerializeField] private GameObject LeftmeteorPrefab; 
    [SerializeField] private Transform playerTransform; 
    [SerializeField] private float spawnRange = 10f; 
    [SerializeField] private float spawnHeight = 10f; 
    [SerializeField] private float spawnInterval = 1f; 

    void Start()
    {
        StartCoroutine(SpawnMeteorsRoutine());
    }

    IEnumerator SpawnMeteorsRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            SpawnMeteorsAbovePlayer();
        }
    }

    void SpawnMeteorsAbovePlayer()
    {
        float randomX = playerTransform.position.x + Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPosition = new Vector3(randomX, playerTransform.position.y + spawnHeight, 0);

        // Spawn the right meteor
        GameObject rightMeteor = Instantiate(RightmeteorPrefab, spawnPosition, Quaternion.identity);
        Rigidbody2D rbRight = rightMeteor.GetComponent<Rigidbody2D>();
        if (rbRight == null)
        {
            Debug.LogWarning("Rigidbody2D component not found on Right meteor prefab.");
        }

        // Spawn the left meteor
        GameObject leftMeteor = Instantiate(LeftmeteorPrefab, spawnPosition, Quaternion.identity);
        Rigidbody2D rbLeft = leftMeteor.GetComponent<Rigidbody2D>();
        if (rbLeft == null)
        {
            Debug.LogWarning("Rigidbody2D component not found on Left meteor prefab.");
        }

        // Destroy the meteors after 10 seconds
        Destroy(rightMeteor, 10);
        Destroy(leftMeteor, 10);
    }
}
