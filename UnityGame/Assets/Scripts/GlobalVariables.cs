// Modified and checked by Rob on 20-06-2016, please do not edit

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GlobalVariables : MonoBehaviour {
	
	// Use this for initialization
	void Start() {

	}
	
	// Update is called once per frame
	void Update() {
		// Reset the game when all the buttons are pressed at the same time
		if (Input.GetButtonDown ("start") && Input.GetButtonDown ("1") && Input.GetButtonDown ("2")) {
			SceneManager.LoadScene (0);
		}
	}
}
