using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour {

	public float				countdownTime;
	public float				lightIntensity;
	public Light				light;
	public UnityEngine.UI.Text	countdownText;

	private float				currCountdownValue;

	// Use this for initialization
	void Start () {
		light.GetComponent<Light>().intensity = lightIntensity;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator StartCountdown () {
		currCountdownValue = countdownTime;
		while (currCountdownValue > 0 && !GlobalVariables.gameCompleted)
		{
			yield return new WaitForSeconds(1.0f);
			currCountdownValue--;
			//Set countdown panel text
			countdownText.text = "" + currCountdownValue + "";

			// Change light intensity - Optional
			// lightIntensity = lightIntensity - 0.01f;
			// light.GetComponent<Light>().intensity = lightIntensity;

			// Set Remaining Time
			GlobalVariables.remainingTime = currCountdownValue;
			// Set Game Over when time is zero
			if (currCountdownValue == 0) {
				GlobalVariables.gameOver = true;
			}
		}
	}
}
