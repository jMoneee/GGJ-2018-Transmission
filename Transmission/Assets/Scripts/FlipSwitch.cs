using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlipSwitch : MonoBehaviour {

	public int index;
	public Sprite leftSwitch;
	public Sprite rightSwitch;

	CableConnections connect;
	int state;
	Image switchImage;

	void Start()
	{
		state = 0;
		switchImage = GetComponent<Image>();
		connect = GameObject.FindGameObjectWithTag ("GameController").GetComponent<CableConnections>();
	}

	public void Flip()
	{
		if (state == 0) {
			switchImage.sprite = rightSwitch;
			state = 1;
			connect.hold [index] = true;
		}
		else{
			switchImage.sprite = leftSwitch;
			state = 0;
			connect.hold [index] = false;
		}
	}
}
