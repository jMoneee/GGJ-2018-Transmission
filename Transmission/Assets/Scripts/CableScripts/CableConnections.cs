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
	public GameObject[] cableImages = new GameObject[4];
	public GameObject cableImageParent;
	public bool[] cableOccupy = new bool[4];
	public bool[] areaOccupy = new bool[18];
	public bool[] hold = new bool[4];
	public bool firstCable;
	public bool firstArea;
	public bool hasConnection;
	public TimeLine timeLine;

	GameObject cableParent;

	void Start()
	{
		hasConnection = false;
		firstCable = false;
		firstArea = false;
		cableIndex = -1;
		areaIndex = -1;

		cableParent = GameObject.FindGameObjectWithTag ("Cables");

		for (int cable = 0; cable < 4; cable++) {
			for (int area = 0; area < 18; area++) {
				cables [cable, area] = cableParent.transform.GetChild (cable).GetChild (area).gameObject;
			}
		}

		for (int image = 0; image < 4; image++) {
			cableImages [image] = cableImageParent.transform.GetChild (image).gameObject;
		}

		for (int x = 0; x < 4; x++) {
			cableOccupy [x] = false;
			hold [x] = false;
		}

		for (int x = 0; x < 18; x++) {
			areaOccupy[x] = false;
		}
	}
		
	public void ToggleConnection()
	{
		cableIndex -= 1;
		areaIndex -= 1;
		if (cableOccupy [cableIndex].Equals(areaOccupy [areaIndex])){
			if ((cableOccupy[cableIndex] == true && firstArea == true) || (cableOccupy[cableIndex] == false && firstCable == true && hold[cableIndex] == true)) {
				cables [cableIndex, areaIndex].SetActive (!cables [cableIndex, areaIndex].gameObject.activeSelf);
				//cableImages [cableIndex].SetActive (!cableImages [cableIndex].gameObject.activeSelf);
				cableOccupy [cableIndex] = !cableOccupy [cableIndex];
				areaOccupy [areaIndex] = !areaOccupy [areaIndex];

				hasConnection = !hasConnection;
			}
			if (hasConnection == false) {
				timeLine.StawpDialogue ();
			}
		}

		cableIndex = -1;
		areaIndex = -1;
		firstCable = false;
		firstArea = false;
	}
}
