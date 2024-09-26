using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawner : MonoBehaviour
{
    [SerializeField] GameObject pointPrefab;
    [SerializeField] PlayerInputHandler playerInputHandler;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPoints();
    }

    void SpawnPoint()
    {
        float rand_x = Random.Range(-14f, 14f);

        Vector3 spawnPos = new Vector3(rand_x, 12f, 0);

        GameObject newObject = Instantiate(pointPrefab, spawnPos, Quaternion.identity);

        Point newPoint = newObject.GetComponent<Point>();

        if(newPoint != null)
        {
            newPoint.SetPlayerInputHandler(playerInputHandler);
        }
    }

    void SpawnPoints()
    {
        StartCoroutine(SpawnPointsRoutine());

        IEnumerator SpawnPointsRoutine()
        {
            while(true)
            {
                SpawnPoint();
                yield return new WaitForSeconds(2f);
            }
            
        }
    }
}
