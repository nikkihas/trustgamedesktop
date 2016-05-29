// Modified by Rob on 27-05-2016, please do not edit

using UnityEngine;
using System.Collections;

public class LowerPlatform2 : MonoBehaviour {
	private bool down = false;
	public Vector3 startPosition;
	public Vector3 endPosition;
	public float speed = 2.0F;

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
			transform.position = Vector3.Lerp(transform.position, endPosition, Time.deltaTime);
		} else {
			transform.position = Vector3.Lerp(transform.position, startPosition, Time.deltaTime);
		}
	}

	// Generate a random interval
	IEnumerator randomlyRisePlatform () {
		var waitTime = Random.Range(1f, 1.5f);
		yield return new WaitForSeconds (waitTime);
		down = false;
	}
}