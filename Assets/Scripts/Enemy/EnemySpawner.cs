using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private Transform[] spawnPoints;
    [SerializeField] private GameObject enemyPrefab;

    [SerializeField] private float spawnInterval = 1f;

    private void Start()
    {
        spawnPoints = GetComponentsInChildren<Transform>();
        InvokeRepeating(nameof(SpawnEnemy), spawnInterval, spawnInterval);
    }

    private void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemyPrefab, spawnPoints[randomIndex].position, Quaternion.identity);
    }
}
