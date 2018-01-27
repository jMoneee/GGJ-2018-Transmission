using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLine : MonoBehaviour {

	public float minutes;

	float seconds;
	float[] eventTime;

	void Start()
	{
		seconds = minutes * 60;
	}
}
