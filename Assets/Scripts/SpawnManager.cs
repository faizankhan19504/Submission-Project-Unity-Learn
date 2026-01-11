
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] EnemyPrefabs;
    // Variables Declaration
    private float spawnRangeX = 8;
    private float spawnPosZ = 9;
    private float spawnHeight = 0.5f;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    // Function for Spawning the enemies at Random Position
    private void SpawnRandomEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnHeight, spawnPosZ);
        int enemyIndex = Random.Range(0, EnemyPrefabs.Length);

        Instantiate(EnemyPrefabs[enemyIndex], spawnPos, EnemyPrefabs[enemyIndex].transform.rotation);
    }

}
