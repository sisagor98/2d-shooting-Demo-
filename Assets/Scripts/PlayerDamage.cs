using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour {
	public LifeBar lb;
	public int hitPoint;
	public GameObject playerDamage;

	void OnTriggerEnter2D(Collider2D other){
		//Debug.Log ("Trigger");
		if (other.gameObject.tag == "eBullet") {
			GameObject GO = Instantiate (playerDamage,transform.position,transform.rotation);
			Destroy (GO, 2.0f);
			hitPoint--;
			lb.lifeIndicator ();
			Destroy (other.gameObject);
			if (hitPoint <= 0) {
				Destroy (gameObject);
				//Debug.Log ("DEAD");
			}
		}
	}
}
