using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // the vectors and variables that the spawner uses to produce a more 'natural' and random spawning system
    public GameObject enemy;
    public float spawnTimer;
    public float spawnSpeed;
    public int laneRoll;
    public Vector3 topLane;
    public Vector3 middleLane;
    public Vector3 bottomLane;

    // Start is called before the first frame update
    void Start()
    {
        // the amount of time that must elapse for an enemy to spawn
        spawnSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        // counts down the timer and then rolls a random number, the outcome of the roll then selects with lane the enemy prefab spawns in
        // the timer then resets back to 0 and the cycle begins again
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnSpeed)
        {
            laneRoll = Random.Range(0, 3);

            if (laneRoll > 1 )
            {
                Instantiate(enemy, topLane, transform.rotation);
            } else if (laneRoll > 0 )
            {
                Instantiate(enemy, middleLane, transform.rotation);
            } else
            {
                Instantiate(enemy, bottomLane, transform.rotation);
            }

            spawnTimer = 0;
        }
    }
}
