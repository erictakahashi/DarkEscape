using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour {

	public float countdownTime;
	public UnityEngine.UI.Text countdownText;

	// Use this for initialization
	void Start () {
		countdownText.text = "" + countdownTime + "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator StartCountdown() {
		float currCountdownValue = countdownTime;
		while (currCountdownValue > 0)
		{
			Debug.Log("Countdown: " + currCountdownValue);
			yield return new WaitForSeconds(1.0f);
			currCountdownValue--;
			countdownText.text = "" + currCountdownValue + "";
		}
	}
}
