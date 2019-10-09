using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public float maxSpeed;
	public float maxRot;
	float shipRadiusBound = 0.5f;
	public virtualjoystick joystick;
	// Use this for initialization
	void Start () {
		
	}
	void Update () {

		Quaternion rot = transform.rotation;
		float z = rot.eulerAngles.z;
		z -= joystick.Horizontal()* maxRot * Time.deltaTime;
		rot = Quaternion.Euler (0, 0, z);
		transform.rotation = rot;

		Vector3 position = transform.position;
		Vector3 velocity = new Vector3 (0, joystick.Vertical() * maxSpeed * Time.deltaTime, 0);
		position += rot * velocity;

		if (position.y+shipRadiusBound> Camera.main.orthographicSize) {
			position.y = Camera.main.orthographicSize - shipRadiusBound;
		}
		if (position.y-shipRadiusBound< -Camera.main.orthographicSize) {
			position.y = -Camera.main.orthographicSize + shipRadiusBound;
		}

		float screenRatio = (float)Screen.width /(float) Screen.height;
		float widthOrtho = Camera.main.orthographicSize * screenRatio;
		if (position.x+shipRadiusBound> widthOrtho) {
			position.x = widthOrtho - shipRadiusBound;
		}
		if (position.x-shipRadiusBound< -widthOrtho) {
			position.x = -widthOrtho + shipRadiusBound;
		}
		transform.position = position;
	}
}
