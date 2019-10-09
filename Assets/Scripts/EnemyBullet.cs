using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

	public GameObject bulletPrefabs;
	public Vector3 bulletOffset = new Vector3 (0, 0.5f, 0);
	private float timer;
	public float delaytime;

	// Use this for initialization
	void Start () {
		timer = delaytime;
	}

	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
				Vector3 offset = transform.rotation * bulletOffset;
				Instantiate (bulletPrefabs, transform.position+offset, transform.rotation);
			timer = delaytime;
		}

	}
}
