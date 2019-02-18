using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskKeyboard : MonoBehaviour {

	public GameObject			deskKeyboard;
	public UnityEngine.UI.Text	displayText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpKeyPressed () {
		if (GlobalVariables.gameStarted && !GlobalVariables.gameOver) {
			char currentLetter 	= displayText.text.ToCharArray () [0];
			currentLetter 		= (currentLetter == 'Z') ? 'A' : (char)(currentLetter + 1);
			displayText.text 	= currentLetter.ToString ();
			// Play audio source
			PlayAudioSource ();
		}
	}

	public void DownKeyPressed () {
		if (GlobalVariables.gameStarted && !GlobalVariables.gameOver) {
			char currentLetter 	= displayText.text.ToCharArray () [0];
			currentLetter 		= (currentLetter == 'A') ? 'Z' : (char)(currentLetter - 1);
			displayText.text 	= currentLetter.ToString ();
			// Play audio source
			PlayAudioSource ();
		}
	}

	private void PlayAudioSource () {
		AudioSource audioSource = deskKeyboard.GetComponentInChildren<AudioSource>();
		audioSource.Play();
	}

}
