using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

public GameObject[] enemies;


	// Use this for initialization
	void Start () {

		}
	
	// Update is called once per frame
	void Update ()
	{
		foreach (GameObject enemy in enemies) {
			if (TimeToSpawn (enemy))
				spawn (enemy);
		}
	}

	void spawn(GameObject enemy)
	{
	Instantiate(enemy,gameObject.transform.position,Quaternion.identity, gameObject.transform);
	}
bool TimeToSpawn (GameObject enemy)
	{
		Attacker enemyattacker = enemy.GetComponent<Attacker> ();
		float meanspawndelay = enemyattacker.spawnTIme;

		float spawnspersecond = 1 / meanspawndelay;
		if (Time.deltaTime > meanspawndelay) {
		Debug.Log("Spawn rate capped by framerate");
		}
		float threshold = spawnspersecond * Time.deltaTime/5;
		if(Random.value < threshold)
		return true;
		else 
		return false;
}
}
