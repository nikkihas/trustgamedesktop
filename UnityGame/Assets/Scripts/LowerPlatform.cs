// Modified by Rob on 06-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class LowerPlatform : MonoBehaviour {
	private Vector3 startPosition;
	private Vector3 endPosition;
	private bool down = false;
	public float speed = 1.0F;

	// Use this for initialization
	void Start () {
		startPosition = new Vector3 (0, 4, -2);
		endPosition = new Vector3 (0, 0, -2);
	}

	// Update is called once per frame
	void Update () {
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

		// Lower the platform when the button is down or rise when it is up
		if (down == true) {
			transform.position = Vector3.Lerp (transform.position, endPosition, Time.deltaTime * speed);
		} else {
			transform.position = Vector3.Lerp (transform.position, startPosition, Time.deltaTime * speed);
		}
	}

	// Generate a random interval
	IEnumerator randomlyRisePlatform () {
		var waitTime = Random.Range(1f, 1.5f);
		yield return new WaitForSeconds (waitTime);
		down = false;
	}
}