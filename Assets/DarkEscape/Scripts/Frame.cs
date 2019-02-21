using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frame : MonoBehaviour {

	public 	GameObject	frame;
	private bool		frameClickedFirstTime;

	// Use this for initialization
	void Start () {
		frame.GetComponent<Rigidbody>().useGravity = false;
		frameClickedFirstTime = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onClick () {
		if (GlobalVariables.gameStarted  && !GlobalVariables.gameOver) {
			frame.GetComponent<Rigidbody>().useGravity = true;
			if (!frameClickedFirstTime) {
				frameClickedFirstTime = true;
				// Add 10 to Exploration Points
				GlobalVariables.explorationPoints += 10;
				// Play audio source
				StartCoroutine (PlayAudioSource ());
			}
		}
	}

	private IEnumerator PlayAudioSource () {
		float audioBuffer = 1;
		while (audioBuffer > 0)
		{
			yield return new WaitForSeconds(0.3f);
			audioBuffer--;
			AudioSource audioSource = frame.GetComponent<AudioSource>();
			audioSource.Play();
		}
	}

}
