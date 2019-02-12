using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {

	public GameObject			introductionPanel;
	public GameObject			gameOverPanel;
	public GameObject			countdown;
	public UnityEngine.UI.Text	completeGameExplorationPoints;
	public UnityEngine.UI.Text	completeGameRemaingTime;

	private float explorationPoints = 0;
	private float remainingTime = 0;

	// Use this for initialization
	void Start () {
		// Hide GameOver Panel
		gameOverPanel.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		if (GlobalVariables.gameCompleted && 
			((completeGameExplorationPoints.text == "" && completeGameRemaingTime.text == "") ||
				explorationPoints != GlobalVariables.explorationPoints ||
				remainingTime != GlobalVariables.remainingTime))
		{
			explorationPoints = GlobalVariables.explorationPoints;
			remainingTime = GlobalVariables.remainingTime;
			// Set Complete Panel points
			completeGameExplorationPoints.text = "" + GlobalVariables.explorationPoints + "";
			completeGameRemaingTime.text = "" + GlobalVariables.remainingTime + "";
		}

		if (GlobalVariables.gameStarted && GlobalVariables.gameOver && !gameOverPanel.activeSelf) {
			GameOver();
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

	public void GameOver() {
		// Display GameOver Panel
		gameOverPanel.SetActive (true);
	}
}
