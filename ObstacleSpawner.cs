using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public Transform[] spawnPoints;
    public float baseSpawnInterval = 1.5f;

    private float timer = 0f;

    void Update()
    {
        if (GameManager.Instance == null) return;

        timer += Time.deltaTime;

        float currentDifficulty = Mathf.Max(1f, GameManager.Instance.difficulty);
        float currentInterval = baseSpawnInterval / currentDifficulty;

        if (timer >= currentInterval)
        {
            SpawnObstacle();
            timer = 0f;
        }
    }

    void SpawnObstacle()
    {
        if (obstaclePrefabs.Length == 0 || spawnPoints.Length == 0)
            return;

        int prefabIndex = Random.Range(0, obstaclePrefabs.Length);
        int laneIndex = Random.Range(0, spawnPoints.Length);

        Transform lane = spawnPoints[laneIndex];
        Vector3 spawnPos = lane.position;

        Instantiate(obstaclePrefabs[prefabIndex], spawnPos, Quaternion.identity);
    }
}
