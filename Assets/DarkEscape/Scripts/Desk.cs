using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk : MonoBehaviour {

	public Animator				drawerStateMachine;
	public GameObject			drawer;
	public UnityEngine.UI.Text	displayText01;
	public UnityEngine.UI.Text	displayText02;
	public UnityEngine.UI.Text	displayText03;

	private bool				isDrawerOpened;

	// Use this for initialization
	void Start () {
		// Start with the drawer closed
		isDrawerOpened = false;
	}
	
	// Update is called once per frame
	void Update () {
		// Get the code - sum text of all displays
		string wordCode = displayText01.text + displayText02.text + displayText03.text;

		if (!isDrawerOpened && wordCode == "USA") {
			// Open drawer
			isDrawerOpened = true;
			// Trigger open drawer animation
			drawerStateMachine.SetBool("open", true);
			// Add 10 to Exploration Points
			GlobalVariables.explorationPoints += 10;
			// Play audio source
			StartCoroutine (PlayAudioSource ());
		}
	}

	private IEnumerator PlayAudioSource () {
		float audioBuffer = 1;
		while (audioBuffer > 0)
		{
			yield return new WaitForSeconds(0.3f);
			audioBuffer--;
			AudioSource audioSource = drawer.GetComponent<AudioSource>();
			audioSource.Play();
		}
	}

}
