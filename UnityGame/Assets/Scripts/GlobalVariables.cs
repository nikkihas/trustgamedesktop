// Modified and checked by Rob on 20-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class GlobalVariables : MonoBehaviour {
	public static bool audioIsPlaying;

	// Use this for initialization
	void Start() {
		// Reset the boolean
		audioIsPlaying = false;
	}
	
	// Update is called once per frame
	void Update() {
		if (audioIsPlaying == true) {
			// Start the coroutine
			StartCoroutine (waitForSeconds ());
		}
	}

	// Wait for a number of seconds
	IEnumerator waitForSeconds() {
		yield return new WaitForSeconds(10.0F);
		audioIsPlaying = false;
	}
}
