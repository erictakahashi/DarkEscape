using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LockKeyboard : MonoBehaviour {

	public Animator				lockStateMachine;
	public Animator				doorStateMachine;
	public GameObject			lockKeyboard;
	public GameObject			card;
	public UnityEngine.UI.Text 	displayText;

	// Use this for initialization
	void Start () {
		// User starts without the card
		card.SetActive (false);
		// Set initial text for the display - "OUT" = out of service
		displayText.text = "OUT";
		displayText.color = new Color(201f/255f, 59f/255f, 59f/255f);
	}
	
	// Update is called once per frame
	void Update () {
		if (GlobalVariables.hasCard) {
			// The user has the card now
			card.SetActive (true);
		}

		// Get string in the display
		string displayedCode = displayText.text;

		if (GlobalVariables.hasCard && displayedCode == "OUT") {
			displayText.text = "";
		} else if (GlobalVariables.hasCard && displayedCode == "1030") {
			displayText.text = "PASS";
			displayText.color = new Color(91f/255f, 251f/255f, 85f/255f);
			// Trigger open door animation
			doorStateMachine.SetBool("open", true);
			// Set game completed
			GlobalVariables.gameCompleted = true;
		}
	}

	public void KeyPressed () {
		if (GlobalVariables.gameStarted && GlobalVariables.hasCard && !GlobalVariables.gameOver) {
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
			// Play audio source
			PlayAudioSource ();
		}
	}

	private void PlayAudioSource () {
		AudioSource audioSource = lockKeyboard.GetComponent<AudioSource>();
		audioSource.Play();
	}

}
