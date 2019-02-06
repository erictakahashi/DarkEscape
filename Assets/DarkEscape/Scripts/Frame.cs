using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frame : MonoBehaviour {

	public GameObject frame;

	// Use this for initialization
	void Start () {
		frame.GetComponent<Rigidbody>().useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onClick () {
		if (GlobalVariables.gameStarted) {
			frame.GetComponent<Rigidbody>().useGravity = true;
		}
	}
}
