using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject SlowEnemyPrefab;
    [SerializeField]
    private GameObject FastEnemyPrefab;
    [SerializeField]
    private GameObject RangedEnemyPrefab;
    [SerializeField]
    private GameObject BossPrefab;

    [SerializeField]
    private float SlowEnemyInterval;
    [SerializeField]
    private float FastEnemyInterval;
    [SerializeField]
    private float RangedEnemyInterval;
    [SerializeField]
    private float BossInterval;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(SlowEnemyInterval, SlowEnemyPrefab));
        StartCoroutine(spawnEnemy(FastEnemyInterval, FastEnemyPrefab));
        StartCoroutine(spawnEnemy(RangedEnemyInterval, RangedEnemyPrefab));
        StartCoroutine(spawnEnemy(BossInterval, BossPrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}