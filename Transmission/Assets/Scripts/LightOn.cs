using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lightOn : MonoBehaviour {

	public int index; //set this to 0-3 depending on line or 4 if direct phone line
	public Sprite lightOnSprite;
	public Sprite lightOffSprite;

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
	public void incomingCall(){ //call this when call is set to come in
		if (state == 0) {
			lightImage.sprite = lightOffSprite;
			state = 1;

		}
	}
	public void endCall(){ //call this when a call is scripted to end
		if (state == 1) {
			lightImage.sprite = lightOnSprite;
			state = 0;
		}
	
	}
		


}
