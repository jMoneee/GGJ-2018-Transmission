using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightOn : MonoBehaviour {

	public int index; //set this to 1-4 depending on line or 5 if direct phone line
	public Sprite lightOn;
	public Sprite lightOff;

	int state;
	Image lightImage;
	// Use this for initialization
	void Start () {
		state = 0;
		lightImage = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void getCall(){ //call this when call is set to come in
		if (state == 0) {
			lightImage.sprite = lightOff;
			state = 1;

		}
	}
	public void endCall(){ //call this when a call is scripted to end
		if (state == 1) {
			lightImage.sprite = lightOn;
			state = 0;
		}
	
	}
		


}
