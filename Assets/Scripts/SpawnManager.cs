using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private float spawnRangeX = 7;
    private float spawnPosY = 10;
    private float spawnPosZ = 0;
    private float startDelay = 1;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomObstacle", startDelay,spawnInterval);
    }

    private void Update()
    {
        
    }

    private void SpawnRandomObstacle()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, spawnPosZ);
        int obstacleIndex = Random.Range(0, obstaclePrefab.Length);
        Instantiate(obstaclePrefab[obstacleIndex], spawnPos, obstaclePrefab[obstacleIndex].transform.rotation);
    }

    
}
