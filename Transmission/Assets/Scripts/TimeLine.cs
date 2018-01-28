using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Class in control of the game timeline
 */
public class TimeLine : MonoBehaviour {

	public float minutes;
	public DisplayText display;

	float seconds;
	float[] eventTime;

	void Start()
	{
		seconds = minutes * 60;

	}
}
