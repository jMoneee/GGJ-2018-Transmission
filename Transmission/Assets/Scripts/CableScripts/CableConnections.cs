using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Class to manage the lines that
 * form between the cable and area buttons
 */
public class CableConnections : MonoBehaviour {

	public GameObject selectedCable;
	public Vector3 cablePos;
	public Vector3 areaPos;
	public bool cableSelected;
	public bool isConnected;
	public LineRenderer line;

	void Start()
	{
		cableSelected = false;
		isConnected = false;
	}
		
	public void MakeLine()
	{
		line = selectedCable.GetComponent<LineRenderer> ();
		line.enabled = true;
		line.SetPosition (0, cablePos);
		line.SetPosition (1, areaPos);
		isConnected = true;
	}
}
