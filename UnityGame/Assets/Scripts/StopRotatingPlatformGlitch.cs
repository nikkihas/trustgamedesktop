// Modified and checked by Rob on 20-06-2016, please do not edit
// Edited by Nikki 27-06-2016, removed "var waitTime"

using UnityEngine;
using System.Collections;

public class StopRotatingPlatformGlitch : MonoBehaviour {
	private bool rotateObject = true;
	public float speed = 100.0F;
	public float delayMinimum = 1.0F;
	public float delayMaximum = 2.0F;

	// Update is called once per frame
	void Update () {
		// Check if the button is down or up
		if (Input.GetButtonDown ("4")) {
			StartCoroutine (randomlyStopPlatform ());
		} 
		if (Input.GetButtonDown ("4")) {
			rotateObject = true;
		}
		// Stop the rotating platform when the button is down or start when it is up
		if (rotateObject == false) {
			transform.Rotate (new Vector3 (0, 0, 0));
			StartCoroutine (randomlyStartPlatform ());
		} else {
			transform.Rotate (new Vector3 (0, 0, Time.deltaTime * speed));
		}
	}

	// Generate a random interval
	IEnumerator randomlyStopPlatform () {
		var waitTime = Random.Range (delayMinimum, delayMaximum);
		yield return new WaitForSeconds (waitTime);
		rotateObject = false;
	}

	// Generate a random interval
	IEnumerator randomlyStartPlatform () {
		//var waitTime = Random.Range (delayMinimum, delayMaximum);
		yield return new WaitForSeconds (3);
		rotateObject = true;
	}
}