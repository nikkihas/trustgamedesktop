// Modified by Rob on 13-06-2016, please do not edit
// Modified by Nikki on 19-06-2016, please reproduce

using UnityEngine;
using System.Collections;

public class MovePlatformGlitch : MonoBehaviour {
	private Vector3 startPosition;
	private Vector3 endPosition;
	private bool down = false;
	public float distance = 3;
	public float speed = 2.0F;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
		endPosition = startPosition + new Vector3 (0, distance, 0);
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
			transform.position = Vector3.Lerp (transform.position, startPosition, Time.deltaTime * speed);
		} else {
			transform.position = Vector3.Lerp (transform.position, endPosition, Time.deltaTime * speed);
		}
	}

	// Generate a random interval
	IEnumerator randomlyRisePlatform () {
		var waitTime = Random.Range(0.5f, 1.0f);
		yield return new WaitForSeconds (waitTime);
		down = false;
	}
}