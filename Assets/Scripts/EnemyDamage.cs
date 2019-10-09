using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

	public GameObject enemyDamage;
	void OnTriggerEnter2D(Collider2D other){
		//Debug.Log ("Trigger");
		if (other.gameObject.tag == "pBullet") {
			GameObject GO = Instantiate (enemyDamage,transform.position,transform.rotation);
			Destroy (this.gameObject);
			Destroy (other.gameObject);
			Destroy (GO, 2.0f);
		}
	}
}
