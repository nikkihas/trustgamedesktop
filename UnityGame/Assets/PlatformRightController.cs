﻿// Modified and checked by Rob on 21-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class PlatformRightController : MonoBehaviour {
	public float delay = 5.0F;

	// Start the coroutine when Charlie enters the object
	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") {
			// Start the coroutine
			StartCoroutine (waitForSeconds ());
		}
	}

	// Stopt the coroutine and reset the booleans when Charlie exits the object
	void OnTriggerExit(Collider col) {
		if (col.gameObject.tag == "Player") {
			// Start the coroutine
			StopAllCoroutines();
			// Reset the booleans
			MovePlatformLeft.move = false;
			MovePlatformMiddle.move = false;
		}
	}

	// Wait for a number of seconds
	IEnumerator waitForSeconds() {
		yield return new WaitForSeconds (1.0F);
		// Set the boolean
		MovePlatformLeft.move = true;
		MovePlatformMiddle.move = true;
		yield return new WaitForSeconds (delay);
		// Reset the booleans
		MovePlatformLeft.move = false;
		MovePlatformMiddle.move = false;
		// Reset Charlie's position
		GameObject.Find ("Player01").transform.position = RigidbodyController.startPosition;
		GameObject.Find ("Player01").transform.rotation = RigidbodyController.startRotation;
	}
}
