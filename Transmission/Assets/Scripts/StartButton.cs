﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void TaskOnClick(){
		SceneManager.LoadScene("Main", LoadSceneMode.Single);
		SceneManager.SetActiveScene ("Main");
	}


}
