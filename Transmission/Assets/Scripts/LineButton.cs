﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StartButton : MonoBehaviour {

	public Button yourButton;
	public int lineNum;
	string buttonName = "Line" + lineNum;
	// Use this for initialization
	void Start () {
		Button btn = yourButton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	// Update is called once per frame
	void Update () {

	}
	void TaskOnClick(){

	}


}