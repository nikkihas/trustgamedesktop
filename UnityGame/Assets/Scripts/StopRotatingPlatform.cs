// Modified by Rob on 06-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class StopRotatingPlatform : MonoBehaviour {
	private bool rotateObject = true;
	public float speed = 100.0F;

	// Update is called once per frame
	void Update () {
		// Check if the button is down or up
		if (Input.GetButtonDown ("2")) {
			rotateObject = false;
		} 
		if (Input.GetButtonUp ("2")) {
			rotateObject = true;
		}

		// Stop the rotating platform when the button is down or start when it is up
		if (rotateObject == false) {
			transform.Rotate (new Vector3 (0, 0, 0));
		} else {
			transform.Rotate (new Vector3 (0, 0, Time.deltaTime * speed));
		}
	}
}