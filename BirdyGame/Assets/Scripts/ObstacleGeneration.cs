using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGeneration : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> obstacles;

    private GameObject obstacleToSpawn;

    float obstacleCooldown;
    float timeToNextSpawn;

    void Start()
    {
        timeToNextSpawn = 0f;
        obstacleCooldown = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToNextSpawn)
        {
            timeToNextSpawn += obstacleCooldown;
            obstacleToSpawn = obstacles[Random.Range(0, obstacles.Count)];

            obstacleToSpawn = Instantiate(obstacleToSpawn);
            //Object.Destroy(obstacleToSpawn, 10.0f);
        }
    }
}
