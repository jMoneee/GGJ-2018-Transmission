using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartButton : MonoBehaviour {

	public Button yourButton;

	// Use this for initialization
	void Start () {
		Button btn = yourButton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void TaskOnClick(){
		SceneManager.LoadScene(1, LoadSceneMode.Single);
	}


}
