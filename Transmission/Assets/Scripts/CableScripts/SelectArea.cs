using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectArea : MonoBehaviour {

	CableConnections connect;
	LineRenderer line;

	void Start()
	{
		connect = GameObject.FindGameObjectWithTag ("GameController").GetComponent<CableConnections> ();
	}

	/*
	 * Single method that handles all possible
	 * interactions with the area button
	 * 
	 * This involves setting a new position, forming the line,
	 * and removing the line
	 */
	public void ToggleLine()
	{
		if (connect.cableSelected == true) {
			AreaPosition ();
		}
		if (connect.cableSelected == true && connect.isConnected == false) {
			FormLine ();
		} else if (connect.isConnected == true) {
			RemoveLine ();
		}
	}

	private void AreaPosition()
	{
		Vector3 areaPos = new Vector3 (transform.position.x, transform.position.y, 5);
		connect.areaPos = areaPos;
	}

	private void FormLine()
	{
		connect.MakeLine ();
		line = connect.line;
	}

	private void RemoveLine()
	{
		line.enabled = false;
		connect.isConnected = false;
		connect.cableSelected = false;
	}
}
