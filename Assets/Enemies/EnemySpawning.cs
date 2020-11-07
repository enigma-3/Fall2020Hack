using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{

    public GameObject[] spawnPoints;
    GameObject currentPoint;        // point we choose to spawn

    int index; 


    public GameObject[] enemies;

    public float minTimeBetweenSpawns;
    public float maxTimeBetweenSpawns;

    public bool canSpawn;

    public float spawnTime;     //how long spawner is active
    public int enemiesInRoom;

    public bool spawnerDone;
    public GameObject spawenerDoneGameObject;


    void SpawnEnemy(){
        index = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index];
        float timeBetweenSpawns = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);

        if(canSpawn){
            Instantiate(enemies[Random.Range(0, enemies.Length)], currentPoint.transform.position, Quaternion.identity);
            enemiesInRoom++;
        }

        Invoke("SpawnEnemy", timeBetweenSpawns);
        if(spawnerDone){
            // Done spawning
            spawenerDoneGameObject.SetActive(true);
        }

    }



    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemy", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
