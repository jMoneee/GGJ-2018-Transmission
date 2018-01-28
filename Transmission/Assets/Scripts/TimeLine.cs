using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Class in control of the game timeline
 */
public class TimeLine : MonoBehaviour {

	public float minutes;
	public DisplayText display;
	public XMLReader xmlReader;
	public float callTimeSeconds;
	public GameObject openParent;

	FlipSwitch[] openSwitches = new FlipSwitch[4];
	int timeIndex;
	float timeLeft;
	List<float> eventTime;
	List<string> dialogues;
	CableConnections connect;

	void Start()
	{
		timeLeft = minutes * 60;
		timeIndex = 0;
		eventTime = xmlReader.readEventTime ();

		connect = GameObject.FindGameObjectWithTag ("GameController").GetComponent<CableConnections>();
		dialogues = xmlReader.readDialogue ("Event Dialogue");
		display.Display (dialogues[2]);


		for (int x = 0; x < 4; x++) {
			openSwitches[x] = openParent.transform.GetChild (x).gameObject.GetComponent<FlipSwitch>();
		}
	}

	void Update()
	{
		timeLeft -= Time.deltaTime;
		//checkTime ();
	}

	void checkTime()
	{
		if (timeLeft < eventTime [timeIndex] * 60) {
			StartCoroutine (Call(0));
			if (timeIndex < eventTime.Count) {
				timeIndex++;
			}
		}
	}

	IEnumerator Call(int index){
		float time = callTimeSeconds;
		while (time > 0) {
			display.Display ("RING RING RING RING RING RING RING RING");
			if (openSwitches[index].state == 1) {
				Answer ();
			}
			time -= 1;
			yield return new WaitForSeconds(1);
		}
		StopAllCoroutines ();
		display.RemoveText ();
	}

	void Answer()
	{
		StopAllCoroutines ();
		display.Display (dialogues [0]);
		StartCoroutine (waitConnect(0, 3));
	}

	IEnumerator waitConnect(int cable, int area)
	{
		while (connect.cableOccupy [cable] == false && connect.areaOccupy [cable] == false) {
			yield return null;
		}
		display.Display (dialogues [1]);
	}
}
