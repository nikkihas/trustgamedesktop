// Modified and checked by Rob on 29-06-2016, please do not edit

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetGameInput : MonoBehaviour {
	
	// Update is called once per frame
	void Update() {
		// Reset the game when all the buttons are pressed at the same time
		if (Input.GetButtonDown ("start") && Input.GetButtonDown ("1") && Input.GetButtonDown ("2")) {
			SceneManager.LoadScene (0);
		}
	}
}
