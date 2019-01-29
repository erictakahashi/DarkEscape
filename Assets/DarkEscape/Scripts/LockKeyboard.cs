using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LockKeyboard : MonoBehaviour {

	public Animator 			lockStateMachine;
	public GameObject			card;
	public UnityEngine.UI.Text 	displayText;

	private bool 				hasCard;

	// Use this for initialization
	void Start () {
		// User starts without the card
		hasCard = false;
		card.SetActive (false);
		// Set initial text for the display - "OUT" = out of service
		displayText.text = "OUT";
	}
	
	// Update is called once per frame
	void Update () {
		// Get string in the display
		string displayedCode = displayText.text;

		 if (hasCard && displayedCode == "OUT") {
			displayText.text = "";
		} else if (hasCard && displayedCode == "1030") {
			displayText.text = "COOL";
		}
	}

	public void KeyPressed () {
		if (hasCard) {
			// Get the button pressed
			GameObject button = EventSystem.current.currentSelectedGameObject;
			// Get the number string of the button
			string number = button.GetComponentInChildren<UnityEngine.UI.Text> ().text;
			// Clear text if the code is wrong
			string displayedCode = displayText.text;
			if (displayedCode != "1030" && displayedCode.Length == 4) {
				displayText.text = "";
			}
			// Append the string
			displayText.text += number;
		}
	}

	public void HasCard () {
		// The user has the card now
		hasCard = true;
		card.SetActive (true);
	}

}
