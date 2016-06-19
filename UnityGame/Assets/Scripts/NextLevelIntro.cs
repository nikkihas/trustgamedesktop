// Modified by Rob on 18-06-2016, please do not edit

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelIntro : MonoBehaviour {
	public float delay = 17.0F;

	// Load the next level after a specific amount of seconds 
	void Start() {
		StartCoroutine (waitForSeconds ());
	}

	// Wait for a number of seconds
	IEnumerator waitForSeconds() {
		yield return new WaitForSeconds(delay);
		StartCoroutine (loadNextLevel ());
		// Set the movement and rotation speed to zero to prevent Charlie from moving
		RigidbodyController.movementSpeed = 0.0F;
		RigidbodyController.rotationSpeed = 0.0F;
	}

	// Wait for a number of seconds
	IEnumerator loadNextLevel() {
		yield return new WaitForSeconds(2.0F);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
}