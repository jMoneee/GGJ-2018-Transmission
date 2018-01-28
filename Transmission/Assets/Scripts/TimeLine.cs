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
		testDialogue = xmlReader.readDialogue ("DialogueFormat");
		display.Display (testDialogue[1]);
	}

	void Update()
	{
		timeLeft -= Time.deltaTime;
		checkTime ();
	}

	void checkTime()
	{
		if (timeLeft < eventTime [timeIndex] * 60) {
			StartCoroutine (Call());
			if (timeIndex < eventTime.Count) {
				timeIndex++;
			}
		}
	}

	IEnumerator Call(){
		float time = callTimeSeconds;
		while (time > 0) {
			Debug.Log ("Ring" + time);
			time -= 1;
			yield return new WaitForSeconds(1);
		}
	}
}
