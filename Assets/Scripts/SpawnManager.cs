
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] EnemyPrefabs;
    private float spawnRangeX = 8;
    private float spawnPosZ = 9;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int enemyIndex = Random.Range(0, EnemyPrefabs.Length);

        Instantiate(EnemyPrefabs[enemyIndex], spawnPos, EnemyPrefabs[enemyIndex].transform.rotation);
    }

}
