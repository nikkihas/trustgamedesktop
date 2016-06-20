// Modified and checked by Rob on 20-06-2016, please do not edit

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelExit : MonoBehaviour {
	private int timesPressed;
	public float delay = 1.0F;

	// Update is called once per frame
	void Update() {
		// Check if the button is pressed
		if (Input.GetButtonDown ("2")) {
			// Increment the variable
			timesPressed++;
		}
	}

	// Load the next level when Charlie exits with the object and the button has been pressed an amount of times
	void OnTriggerExit (Collider col) {
		if (col.gameObject.tag == "Player" && timesPressed > 20) {
			// Set Charlie's movement and rotation speed to zero to prevent him from moving
			RigidbodyController.movementSpeed = 0.0F;
			RigidbodyController.rotationSpeed = 0.0F;
			// Start the coroutine
			StartCoroutine (fadeScreen ());
		}
	}

	// Fade the screen to black
	IEnumerator fadeScreen() {
		float fadeTime =  GameObject.Find("GameManager").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds(fadeTime);
		// Start the coroutine
		StartCoroutine(waitForSeconds ());
	}

	// Wait for a number of seconds and load the next level
	IEnumerator waitForSeconds() {
		yield return new WaitForSeconds(delay);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
}