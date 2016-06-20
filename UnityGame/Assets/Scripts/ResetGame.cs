// Modified and checked by Rob on 20-06-2016, please do not edit

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour {
	public float delay = 60.0F;

	// Load the first level after a specific amount of seconds 
	void Start() {
		// Start the coroutine
		StartCoroutine (waitForSeconds ());
	}

	// Wait for a number of seconds
	IEnumerator waitForSeconds() {
		yield return new WaitForSeconds(delay);
		SceneManager.LoadScene(0);
	}
}