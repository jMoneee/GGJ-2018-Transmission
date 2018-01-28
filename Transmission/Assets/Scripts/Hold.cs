using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Class that will put remove the text of the dialogue box when the hold
 * buttons are pushed
 */
public class Hold : MonoBehaviour {

	public DisplayText display;

	public void PlaceHold()
	{
		display.RemoveText ();
	}
}
