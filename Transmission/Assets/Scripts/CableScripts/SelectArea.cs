using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectArea : MonoBehaviour {

	public int areaIndex;
	CableConnections connect;

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
	public void SetAreaPos()
	{
		connect.areaIndex = areaIndex;
		if (connect.cableIndex != -1 && connect.areaIndex != -1) {
			connect.ToggleConnection ();
		}
	}
}
