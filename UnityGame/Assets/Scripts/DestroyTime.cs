// Modified by Rob on 28-11-2016, please do not edit

using UnityEngine;
using System.Collections;

public class DestroyTime : MonoBehaviour {
	public float delay = 5.0F;

	// Use this for initialization
	void Start() {
		// Start the coroutine
		StartCoroutine (waitForSeconds());
	}
	
	// Wait for a specified amount of time
	IEnumerator waitForSeconds() {
		yield return new WaitForSeconds(delay);
		// Destroy the game object
		Destroy(gameObject);
	}
}
