using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingScript : MonoBehaviour {
	public GameObject bulletPrefabs;
	public Vector3 bulletOffset = new Vector3 (0, 0.5f, 0);
//	private float timer;
//	public float delaytime;
//	void Start () {
//		timer = delaytime;
//	}

	public void fire()
	{
		Vector3 offset = transform.rotation * bulletOffset;
		Instantiate (bulletPrefabs, transform.position + offset, transform.rotation);
	}
	
//	// Update is called once per frame
//	void Update () {
//		timer -= Time.deltaTime;
//		if (timer <= 0) {
//			if (isFire==1) {
//
//				Vector3 offset = transform.rotation * bulletOffset;
//				Instantiate (bulletPrefabs, transform.position + offset, transform.rotation);
//			} else
//				isFire = 0;
//			timer = delaytime;
//		}
//
//
//	}


}
