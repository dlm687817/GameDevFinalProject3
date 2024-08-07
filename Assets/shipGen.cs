using System.Collections;
using UnityEngine;

public class shipGen : MonoBehaviour
{
    [SerializeField] private GameObject shipsPrefab;
    [SerializeField] private float spawnRange = 6f; 
    [SerializeField] private float spawnHeight = 10f; 
    [SerializeField] private float spawnInterval = 2f; 

    void Start()
    {
        StartCoroutine(SpawnSpaceshipsRoutine());
    }

    IEnumerator SpawnSpaceshipsRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            SpawnSpaceshipsRandom();
        }
    }

    void SpawnSpaceshipsRandom()
    {
        float randomX = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPosition = new Vector3(randomX, spawnHeight, 0);

        GameObject newSpaceship = Instantiate(shipsPrefab, spawnPosition, Quaternion.identity);

        Rigidbody2D rb = newSpaceship.GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogWarning("Rigidbody2D component not found on spaceship prefab.");
        }

        Destroy(newSpaceship, 8);
    }
}
