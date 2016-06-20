// Modified and checked by Rob on 20-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class MovePlatformGlitch : MonoBehaviour {
	private Vector3 startPosition;
	private Vector3 endPosition;
	private bool down = false;
	public float distance = 3;
	public float speed = 0.5F;
	public float delayMinimum = 1.0F;
	public float delayMaximum = 2.0F;

	// Use this for initialization
	void Start() {
		startPosition = transform.position;
		endPosition = startPosition + new Vector3 (0, distance, 0);
	}

	// Update is called once per frame
	void Update() {
		// Check if the button is down or up
		if (Input.GetButtonDown ("1")) {
			down = true;
			// Start the coroutine
			StartCoroutine (randomlyRisePlatform());
		}
		if (Input.GetButtonUp ("1")) {
			down = false;
			// Stop the coroutine
			StopAllCoroutines ();
		}
		// Move the platform
		if (down == true) {
			transform.position = Vector3.Lerp (transform.position, startPosition, Time.deltaTime * speed);
		} else {
			transform.position = Vector3.Lerp (transform.position, endPosition, Time.deltaTime * speed);
		}
	}

	// Generate a random interval
	IEnumerator randomlyRisePlatform() {
		var waitTime = Random.Range(delayMinimum, delayMaximum);
		yield return new WaitForSeconds (waitTime);
		down = false;
	}
}