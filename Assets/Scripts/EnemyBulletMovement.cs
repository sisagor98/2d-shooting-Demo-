using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour {
	public float maxSpeed;


	void Start () {

		Destroy (this.gameObject, 2f);
	}

	// Update is called once per frame
	void Update () {
		Vector3 position = transform.position;
		Vector3 velocity = new Vector3 (0,maxSpeed*Time.deltaTime, 0);
		position += transform.rotation * velocity;
		transform.position = position;
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "pBullet") {
			Destroy (other.gameObject);
			Destroy (this.gameObject);
		}
	}
}
