using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Credits : MonoBehaviour {

	public Button yourButton;
	public GameObject myPanel;

	// Use this for initialization
	void Start () {
		Button btn = yourButton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	// Update is called once per frame
	void Update () {

	}
	void TaskOnClick(){
		myPanel.SetActive(true);
	}


}
