using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Class that resets the dialogue box and starts 
 * displaying characters slowly
 */
public class DisplayText : MonoBehaviour {

	public float delay = 0.2f;
	public Text dialogueBox;

	IEnumerator dialogueRoutine;

	void Start()
	{
		dialogueBox = this.GetComponent<Text> ();
	}

	public void Display(string dialogue)
	{
		if (dialogue != null) {
			if (dialogueRoutine != null) {
				StopCoroutine (dialogueRoutine);
			}
			dialogueBox.text = "";
			dialogueRoutine = placeCharacters (dialogue);
			StartCoroutine (dialogueRoutine);
		}
	}


	IEnumerator placeCharacters(string dialogue)
	{
		foreach (char letter in dialogue.ToCharArray()) {
			dialogueBox.text += letter;
			yield return new WaitForSeconds (delay);
		}
	}

	public void RemoveText ()
	{
		if (dialogueRoutine != null) {
			StopCoroutine (dialogueRoutine);
		}
		dialogueBox.text = "";
	}

}
