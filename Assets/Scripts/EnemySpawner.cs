using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemyPrefabs;
	public float waitTime = 0.5f;


	void Start () {
		StartCoroutine ("spawnWait");

	}
	IEnumerator spawnWait()
	{
		
		yield return new WaitForSeconds (waitTime);
		Instantiate (enemyPrefabs, transform.position, transform.rotation);
		Start ();
	}
}
