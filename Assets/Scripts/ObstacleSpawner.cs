using UnityEngine;
using System.Collections;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject Obstacle1;
    public GameObject Obstacle2;
    public float spawnInterval = 1f;

    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while(true)
        {
            SpawnObstacle(Obstacle1);
            yield return new WaitForSeconds(1f);
            SpawnObstacle(Obstacle2);
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnObstacle(GameObject obstacle)
    {
        Vector3 spawnPos = transform.position;
        int side = Random.Range(0, 2) == 0 ? -1 : 1;
        spawnPos.z += (side == 1 ? 1f : -1f);

        Instantiate(obstacle, spawnPos, Quaternion.Euler(0, -90, 0));
        //Instantiate(obstacle, spawnPos, Quaternion.identity);
    }
}
