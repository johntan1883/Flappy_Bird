using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] ObstaclePrefabs;
    public float SpawnInterval = 1f;

    private float spawnTimer;
    // Update is called once per frame
    private void Start()
    {
        spawnTimer = SpawnInterval;
    }
    void Update()
    {
       if(spawnTimer > 0f) 
        { 
            spawnTimer -= Time.deltaTime;
            return;
        }

        spawnTimer = SpawnInterval;

        int random = Random.Range(0, ObstaclePrefabs.Length);


        GameObject.Instantiate(ObstaclePrefabs[random],transform.position,transform.rotation);
    }
}
