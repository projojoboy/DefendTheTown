using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {

    private GameObject[] spawnPoints;
    private GameObject currentSpawnPoint;

    [SerializeField] private float waitTillSpawn = 3;
    [SerializeField] private float minusTime = 0.1f;

    [SerializeField] private GameObject enemyPrefab;

    int index;

	// Use this for initialization
	void Start () {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        StartCoroutine(StartSpawn());
	}

    IEnumerator StartSpawn()
    {
        yield return new WaitForSeconds(waitTillSpawn);
        SpawnEnemy();
        StartCoroutine(StartSpawn());
    }

    void SpawnEnemy()
    {
        index = Random.Range(0, spawnPoints.Length);
        currentSpawnPoint = spawnPoints[index];
        var spawnPointPos = currentSpawnPoint.transform.position;
        Instantiate(enemyPrefab, new Vector3(spawnPointPos.x, spawnPointPos.y, spawnPointPos.z), Quaternion.identity);
    }
}
