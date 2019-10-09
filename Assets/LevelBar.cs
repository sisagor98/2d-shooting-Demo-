using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelBar : MonoBehaviour {

	int score = 0;


	public Slider levelBar;

	public void levelbarIndicator()
	{
		levelBar.value += 0.1f;
	}
	public void Count()
	{
		score++;
		Debug.Log (score);
	}
}
