using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Class that will contain all string arrays
 * full of dialogues and the event times
 */
public class DataContainer : MonoBehaviour {

	List<float> EventTimes;
	XMLReader read;

	void Start()
	{
		read = GameObject.FindGameObjectWithTag ("GameController").GetComponent<XMLReader> ();

		EventTimes = read.readEventTime ();
	}
}
