using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
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
        spawnSpeed = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnSpeed)
        {
            laneRoll = Random.Range(0, 3);

            if (laneRoll > 2 )
            {
                Instantiate(enemy, topLane, transform.rotation);
            } else if (laneRoll > 1 )
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
