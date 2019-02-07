using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour {

	public float countdownTime;
	public UnityEngine.UI.Text countdownText;

	private float currCountdownValue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator StartCountdown() {
		currCountdownValue = countdownTime;
		while (currCountdownValue > 0 && !GlobalVariables.gameCompleted)
		{
			yield return new WaitForSeconds(1.0f);
			currCountdownValue--;
			countdownText.text = "" + currCountdownValue + "";
		}
	}
}
