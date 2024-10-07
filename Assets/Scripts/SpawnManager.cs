using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] targetPrefabs;
    private float spawnRangeX = 23;
    private float spawnRangeZ = 23;
    private float startDelay = 2.0f;
    private float spawnInterval = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomTarget", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomTarget", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomTarget", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomTarget()
    {
        int targetIndex = Random.Range(0, targetPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 3 , Random.Range(-spawnRangeZ, spawnRangeZ));
        
        Instantiate(targetPrefabs[targetIndex], spawnPos, targetPrefabs[targetIndex].transform.rotation);
    }
}
