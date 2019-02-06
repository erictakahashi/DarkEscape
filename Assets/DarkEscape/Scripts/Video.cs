using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video : MonoBehaviour {

	public GameObject						videoObject;

	private UnityEngine.Video.VideoPlayer	videoPlayer;

	// Use this for initialization
	void Start () {
		videoPlayer = videoObject.GetComponent<UnityEngine.Video.VideoPlayer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void videoPlay () {
		if (GlobalVariables.gameStarted) {
			videoPlayer.Play ();
		}
	}

	public void videoPause () {
		if (GlobalVariables.gameStarted) {
			videoPlayer.Pause ();
		}
	}

}
