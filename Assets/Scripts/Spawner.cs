using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] hazards;

    public float timeBtwSpawns;
    public float startTimeBtwSpawns;

    public float minTimeBtwSpawns;
    public float descrease;

    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            if (timeBtwSpawns <= 0)
            {
                Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
                GameObject randomHazard = hazards[Random.Range(0, hazards.Length)];

                Instantiate(randomHazard, randomSpawnPoint.position, Quaternion.identity);
                if (startTimeBtwSpawns > minTimeBtwSpawns)
                {
                    startTimeBtwSpawns -= descrease;
                }

                timeBtwSpawns = startTimeBtwSpawns;
            }
            else
            {
                timeBtwSpawns -= Time.deltaTime;
            }
        }
    }
}
