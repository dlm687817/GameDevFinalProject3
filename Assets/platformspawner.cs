using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab; 
    public float spawnHeight = 10f; 
    public float minSpawnX = -5f; 
    public float maxSpawnX = 5f; 
    public float spawnInterval = 2f; 
    private float lastSpawnY; 
    private Transform playerTransform;

    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerTransform = player.transform;
            lastSpawnY = playerTransform.position.y;
            SpawnPlatform();
        }
        else
        {
            Debug.LogError("Player GameObject with tag 'Player' not found.");
        }
    }

    void Update()
    {
        if (playerTransform != null && playerTransform.position.y > lastSpawnY - spawnHeight + spawnInterval)
        {
            SpawnPlatform();
        }
    }

    void SpawnPlatform()
    {
        float spawnY = lastSpawnY + spawnHeight;
        float spawnX = Random.Range(minSpawnX, maxSpawnX);
        Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0);
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        lastSpawnY = spawnY;
    }
}
