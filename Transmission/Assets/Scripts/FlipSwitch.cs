using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlipSwitch : MonoBehaviour {

	public Sprite leftSwitch;
	public Sprite rightSwitch;

	int state;
	Image switchImage;

	void Start()
	{
		state = 0;
		switchImage = GetComponent<Image>();
	}

	public void Flip()
	{
		if (state == 0) {
			switchImage.sprite = rightSwitch;
			state = 1;
		}
		else{
			switchImage.sprite = leftSwitch;
			state = 0;
		}
	}
}
