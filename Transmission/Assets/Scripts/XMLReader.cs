using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Linq;
using System.Linq;

/*
 * Class to read the XML Files
 */
public class XMLReader : MonoBehaviour {

	/*
	 * Method to read each dialogue xml
	 */
	public List<string> readDialogue(string dialogueFile)
	{
		List<string> dialogueList = new List<string> ();

		TextAsset txtXmlAsset = Resources.Load<TextAsset> (dialogueFile);
		var doc = XDocument.Parse (txtXmlAsset.text);

		var allDialogue = doc.Elements ("Scripts");

		foreach (var oneDialogue in allDialogue) {
			var dialogue = oneDialogue.Elements ("dialogue");
			XElement element = dialogue.ElementAt (0);
			string replaced = element.ToString ().Replace ("<dialogue>", "").Replace ("</dialogue>", "");

			dialogueList.Add (replaced);
		}

		return dialogueList;
	}

	/*
	 * Method to read the event times
	 */
	public List<float> readEventTime()
	{
		List<float> timeList = new List<float> ();

		TextAsset txtXmlAsset = Resources.Load<TextAsset> ("EventTimes");
		var doc = XDocument.Parse (txtXmlAsset.text);

		var allTimes = doc.Element ("EventTimes").Elements("time");

		foreach (var oneDialogue in allTimes) {
			var time = oneDialogue.Elements ("time");
			XElement element = time.ElementAt(0);

			timeList.Add ((float) element);
		}

		return timeList;
	}
}
