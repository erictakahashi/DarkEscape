using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	public GameObject introductionPanel;
	public GameObject countdown;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartGame () {
		// Hide Intro panel
		introductionPanel.SetActive (false);

		// Start Countdown
		StartCoroutine (countdown.GetComponent<Countdown>().StartCountdown ());
	}
}
