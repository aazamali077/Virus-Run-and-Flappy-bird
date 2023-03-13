using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleS : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX, minX, maxY, minY, timeBetweenspawn;
    private float spawnTime;

    void Update()
    {
        if (Time.time>spawnTime)
        {
            spawn();
            spawnTime = Time.time+timeBetweenspawn;
        }
    }

    void spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
