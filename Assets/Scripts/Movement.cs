﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float maxSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = transform.position;
		Vector3 velocity = new Vector3 (0, maxSpeed * Time.deltaTime, 0);
		position += transform.rotation * velocity;
		transform.position = position;
	}
}
