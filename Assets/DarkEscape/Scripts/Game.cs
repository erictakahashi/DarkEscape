using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {

	public GameObject introductionPanel;
	public GameObject countdown;
	public UnityEngine.UI.Text completeGameExplorationPoints;
	public UnityEngine.UI.Text completeGameRemaingTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GlobalVariables.gameCompleted) {
			completeGameExplorationPoints.text = "" + GlobalVariables.explorationPoints + "";
			completeGameRemaingTime.text = "" + GlobalVariables.remainingTime + "";
		}
	}

	public void StartGame () {
		// Set game started
		GlobalVariables.gameStarted = true;
		// Hide Intro panel
		introductionPanel.SetActive (false);
		// Start Countdown
		StartCoroutine (countdown.GetComponent<Countdown>().StartCountdown ());
	}

	public void RestartGame() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
