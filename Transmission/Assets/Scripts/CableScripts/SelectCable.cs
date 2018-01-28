using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Class to select the cable
 */
public class SelectCable : MonoBehaviour {

	public int cableIndex;
	CableConnections connect;

	void Start()
	{
		connect = GameObject.FindGameObjectWithTag ("GameController").GetComponent<CableConnections>();
	}
		
	public void setCablePos()
	{
		connect.cableIndex = cableIndex;
		if (connect.cableIndex != -1 && connect.areaIndex != -1) {
			connect.ToggleConnection ();
		}
	}
}
