using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour {

	public Animator		cardStateMachine;
	public GameObject	AudioSource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCardPointerEnter () {
		cardStateMachine.SetBool ("hovered", true);
	}

	public void OnCardPointerExit () {
		cardStateMachine.SetBool ("hovered", false);
	}

	public void OnCardPointerClick () {
		// Inform the Door Lock that the user has the card
		GlobalVariables.hasCard = true;

		// Destroy the Card game object
		Destroy (gameObject);
		// Play audio source
		PlayAudioSource ();
	}

	private void PlayAudioSource () {
		AudioSource audioSource = AudioSource.GetComponent<AudioSource>();
		audioSource.Play();
	}

}
