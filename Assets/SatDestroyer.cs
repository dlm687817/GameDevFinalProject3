using System.Collections;
using UnityEngine;

public class SatDestroyer : MonoBehaviour
{
    [SerializeField] private GameObject RightsatelliteDebrisPrefab; 
    [SerializeField] private GameObject LeftsatelliteDebrisPrefab; 
    [SerializeField] private Transform playerTransform; 
    [SerializeField] private float spawnRange = 10f; 
    [SerializeField] private float spawnHeight = 10f; 
    [SerializeField] private float spawnInterval = 1f; 

    void Start()
    {
        StartCoroutine(SpawnDebrisRoutine());
    }

    IEnumerator SpawnDebrisRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            SpawnDebrisAbovePlayer();
        }
    }

    void SpawnDebrisAbovePlayer()
    {
        float randomX = playerTransform.position.x + Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPosition = new Vector3(randomX, playerTransform.position.y + spawnHeight, 0);

        // Spawn the right satellite debris
        GameObject rightDebris = Instantiate(RightsatelliteDebrisPrefab, spawnPosition, Quaternion.identity);
        Rigidbody2D rbRight = rightDebris.GetComponent<Rigidbody2D>();
        if (rbRight == null)
        {
            Debug.LogWarning("Rigidbody2D component not found on Right satellite debris prefab.");
        }

        // Spawn the left satellite debris
        GameObject leftDebris = Instantiate(LeftsatelliteDebrisPrefab, spawnPosition, Quaternion.identity);
        Rigidbody2D rbLeft = leftDebris.GetComponent<Rigidbody2D>();
        if (rbLeft == null)
        {
            Debug.LogWarning("Rigidbody2D component not found on Left satellite debris prefab.");
        }

        // Destroy the debris after 10 seconds
        Destroy(rightDebris, 10);
        Destroy(leftDebris, 10);
    }
}
