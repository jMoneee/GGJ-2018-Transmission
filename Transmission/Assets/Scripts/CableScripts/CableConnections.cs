using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Class to manage the lines that
 * form between the cable and area buttons
 */
public class CableConnections : MonoBehaviour {

	public int cableIndex;
	public int areaIndex;
	public GameObject[,] cables = new GameObject[4, 18];

	GameObject cableParent;

	void Start()
	{
		cableIndex = -1;
		areaIndex = -1;

		cableParent = GameObject.FindGameObjectWithTag ("Cables");

		for (int cable = 0; cable < 4; cable++) {
			for (int area = 0; area < 18; area++) {
				cables [cable, area] = cableParent.transform.GetChild (cable).GetChild (area).gameObject;
			}
		}
	}
		
	public void ToggleConnection()
	{
		Debug.Log (cables [cableIndex, areaIndex].gameObject.activeSelf);
		cableIndex -= 1;
		areaIndex -= 1;
		cables [cableIndex, areaIndex].SetActive (!cables[cableIndex, areaIndex].gameObject.activeSelf);
		cableIndex = -1;
		areaIndex = -1;
	}
}
