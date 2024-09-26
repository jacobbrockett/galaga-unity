using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject obstaclePrefab;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObstacles();
    }

    void SpawnObstacle()
    {
        float rand_x = Random.Range(-14f, 14f);

        Vector3 spawnPos = new Vector3(rand_x, 14f, 0);

        GameObject newObject = Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
    }

    void SpawnObstacles()
    {
        StartCoroutine(SpawnObstaclesRoutine());

        IEnumerator SpawnObstaclesRoutine()
        {
            while(true)
            {
                SpawnObstacle();
                yield return new WaitForSeconds(0.5f);
            }
            
        }
    }
}
