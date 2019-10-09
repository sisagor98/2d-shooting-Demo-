using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LifeBar : MonoBehaviour {

	public Slider lifeBar;

	public void lifeIndicator()
	{
		lifeBar.value -= 0.1f;
	}
}
