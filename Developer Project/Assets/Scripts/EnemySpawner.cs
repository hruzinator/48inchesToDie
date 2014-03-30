using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	public Transform enemyPrefect;
	public float respawnFrequency = 5f;

	//range is from negative spawn rang to positive spawn range
	public float maxSpawnRange = 50f;
	public float minSpawnRange = 0.5f;
	
	public float minFrequency;
	public float tdist;
	public float alpha;

	private float lastSpawn;

	// Use this for initialization
	void Start () {
		lastSpawn = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 0) { //the game is paused
						lastSpawn = Time.time;
			}
		else {
			if (respawnFrequency * (alpha * (1 / Mathf.Exp (tdist * Time.time))) >= minFrequency) {
				respawnFrequency = respawnFrequency * (alpha * (1 / Mathf.Exp (tdist * Time.time)));
			}
			else {
				respawnFrequency = minFrequency;
			}
			if (Time.time - respawnFrequency > lastSpawn) {
				lastSpawn += respawnFrequency;
				SpawnEnemy ();
			}
		}
	}

	void SpawnEnemy(){
		Transform nextEnemy = Instantiate (enemyPrefect) as Transform;
		Vector2 newPosition;
		do{
			newPosition = Random.insideUnitCircle * 5;
		}while(newPosition.x > minSpawnRange && newPosition.y > minSpawnRange);

		nextEnemy.position = newPosition;
	}
}

