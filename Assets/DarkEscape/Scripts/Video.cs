using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video : MonoBehaviour {

	public	GameObject						videoObject;
	public	GameObject						videoControls;

	private UnityEngine.Video.VideoPlayer	videoPlayer;
	private bool							videoPlayedFirstTime;

	// Use this for initialization
	void Start () {
		videoPlayer = videoObject.GetComponent<UnityEngine.Video.VideoPlayer> ();
		videoPlayedFirstTime = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void videoPlay () {
		if (GlobalVariables.gameStarted && !GlobalVariables.gameOver) {
			if (!videoPlayedFirstTime) {
				videoPlayedFirstTime = true;
				// Add 10 to Exploration Points
				GlobalVariables.explorationPoints += 10;
			}

			videoPlayer.Play ();
			// Play audio source
			PlayAudioSource ();
		}
	}

	public void videoPause () {
		if (GlobalVariables.gameStarted && !GlobalVariables.gameOver) {
			videoPlayer.Pause ();
			// Play audio source
			PlayAudioSource ();
		}
	}

	private void PlayAudioSource () {
		AudioSource audioSource = videoControls.GetComponent<AudioSource>();
		audioSource.Play();
	}

}
