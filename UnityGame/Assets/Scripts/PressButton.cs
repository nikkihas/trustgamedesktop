// Modified and checked by Rob on 31-10-2016, please do not edit

using UnityEngine;
using System.Collections;

public class PressButton : MonoBehaviour {
	private Vector3 startPosition;
	private Vector3 endPosition;
	private bool down = false;
	public float speed = 2.0F;

	// Use this for initialization
	void Start() {
		// Set the start posistion
		startPosition = transform.position;
		// Set the end posistion
		endPosition = startPosition - new Vector3 (0, 0.15F, 0);
	}

	// Update is called once per frame
	void Update() {
		// Move the button down or up
		if (down == true) {
			transform.position = Vector3.Lerp(transform.position, endPosition, Time.deltaTime * speed);
		} else {
			transform.position = Vector3.Lerp(transform.position, startPosition, Time.deltaTime * speed);
		}
	}

	// Start the coroutine when Charlie enters the object
	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") {
			// Start the coroutine
			StartCoroutine (waitForSeconds ());
		}
	}

	// Stopt the coroutine and reset the boolean when Charlie exits the object
	void OnTriggerExit(Collider col) {
		if (col.gameObject.tag == "Player") {
			// Stop the coroutine
			StopAllCoroutines();
			// Reset the booleans
			down = false;
		}
	}

	// Wait for a number of seconds
	IEnumerator waitForSeconds() {
		yield return new WaitForSeconds (0.2F);
		// Set the boolean
		down = true;
		// Increment the times pressed
		DoorController.timesPressed++;
	}
}