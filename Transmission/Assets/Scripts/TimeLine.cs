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

	int timeIndex;
	float timeLeft;
	List<float> eventTime;
	List<string> testDialogue;

	void Start()
	{
		timeLeft = minutes * 60;
		timeIndex = 0;
		eventTime = xmlReader.readEventTime ();
	}

	void Update()
	{
		timeLeft -= Time.deltaTime;
		checkTime ();
	}

	void checkTime()
	{
		Debug.Log (timeLeft < eventTime [timeIndex] * 60);
		if (timeLeft < eventTime [timeIndex] * 60) {
			
			StartCoroutine ("Call");
		}
	}

	IEnumerator Call(){
		while (callTimeSeconds > 0) {
			Debug.Log ("Ring");
			callTimeSeconds -= Time.deltaTime;
		}
		yield return null;
	}
}
