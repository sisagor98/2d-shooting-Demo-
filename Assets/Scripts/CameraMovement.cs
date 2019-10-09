using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
	public Transform myTarget;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (myTarget != null) {
			Vector3 tarpos = myTarget.position;
			tarpos.z = transform.position.z;
			transform.position = tarpos;
		}

	}
}
