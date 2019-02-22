using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	public GameObject	door;
	public Animator		doorStateMachine;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GlobalVariables.gameCompleted && !doorStateMachine.GetBool("open")) {
			open ();
		}
	}

	private void open () {
		// Trigger open door animation
		doorStateMachine.SetBool("open", true);
		// Play audio source
		PlayAudioSource ();
	}

	private void PlayAudioSource () {
		AudioSource audioSource = door.GetComponent<AudioSource>();
		audioSource.Play();
	}

}
