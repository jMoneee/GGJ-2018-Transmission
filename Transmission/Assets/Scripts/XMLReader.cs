using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Linq;
using System.Linq;

public class XMLReader : MonoBehaviour {

	public List<string> readDialogue(string dialogueFile)
	{
		List<string> dialogueList = new List<string> ();

		TextAsset txtXmlAsset = Resources.Load<TextAsset> (dialogueFile);
		var doc = XDocument.Parse (txtXmlAsset.text);

		var allDialogue = doc.Element ("Script").Elements ("Script");

		foreach (var oneDialogue in allDialogue) {
			var dialogue = oneDialogue.Elements ("dialogue");
			XElement element = dialogue.ElementAt (0);
			string replaced = element.ToString ().Replace ("<dialogue>", "").Replace ("</dialogue>", "");

			dialogueList.Add (replaced);
		}

		return dialogueList;
	}

	public List<float> readEventTime()
	{
		List<float> timeList = new List<float> ();

		TextAsset txtXmlAsset = Resources.Load<TextAsset> ("EventTimes");
		var doc = XDocument.Parse (txtXmlAsset.text);

		var allTimes = doc.Elements ("time");

		foreach (var oneDialogue in allTimes) {
			var time = oneDialogue.Elements ("dialogue");
			XElement element = time.ElementAt (0);
			string replaced = element.ToString ().Replace ("<time>", "").Replace ("</time>", "");

			timeList.Add (replaced);
		}

		return timeList;
	}
}
