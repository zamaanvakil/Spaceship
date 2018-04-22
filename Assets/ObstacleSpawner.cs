using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

	public Transform[] spawnPoints;

	public GameObject blockPrefab;

	public float timeBetweenWaves = 1f;

	private float timeToSpawn = 2f;

	void Start () {
		//SpawnBlocks();
	}

	void Update () {

		if (Time.time >= timeToSpawn)
		{
			SpawnBlocks();
			timeToSpawn = Time.time + timeBetweenWaves;
		}

	}

	void SpawnBlocks ()
	{
		FindObjectOfType<Score>().score++;
		int randomIndex1 = Random.Range(0, spawnPoints.Length);
		int randomIndex2 = Random.Range(0, spawnPoints.Length);
		int randomIndex3 = Random.Range(0, spawnPoints.Length);

		for (int i = 0; i < spawnPoints.Length; i++)
		{
			if (randomIndex1 != i && randomIndex2 != i && randomIndex3 != i)
			{
				Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
			}
		}
	}
	
}
