using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Class to select the cable
 */
public class SelectCable : MonoBehaviour {

	CableConnections connect;

	void Start()
	{
		connect = GameObject.FindGameObjectWithTag ("GameController").GetComponent<CableConnections>();
	}
		
	public void setCablePos()
	{
		Vector3 cablePos = new Vector3 (transform.position.x, transform.position.y, 5);
		connect.cablePos = cablePos;
		connect.selectedCable = this.gameObject;
		connect.cableSelected = true;
	}
}
