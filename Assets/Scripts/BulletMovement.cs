using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

	public float maxSpeed;
	public AudioSource playerBulletSound;
	void Awake()
	{
		playerBulletSound.enabled = true;
	}

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
}
