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
	public GameObject[,] cables;

	void Start()
	{
		cableIndex = -1;
		areaIndex = -1;
	}
		
	public void ToggleConnection()
	{
		cables [cableIndex, areaIndex].SetActive (!cables[cableIndex, areaIndex].activeSelf);
		cableIndex = -1;
		areaIndex = -1;
	}
}
