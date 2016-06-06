// Modified by Rob on 06-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class RisePlatform : MonoBehaviour {
	private Vector3 startPosition;
	private Vector3 endPosition;
	private bool down = false;
	public float speed = 2.0F;

	// Use this for initialization
	void Start () {
		startPosition = new Vector3 (0, -2, 2);
		endPosition = new Vector3 (0, 0, 2);
	}

	// Update is called once per frame
	void Update () {
		// Check if the button is down or up
		if (Input.GetButtonDown ("2")) {
			down = true;
		}
		if (Input.GetButtonUp ("2")) {
			down = false;
		}

		// Lower the platform when the button is down or rise when it is up
		if (down == true) {
			transform.position = Vector3.Lerp (transform.position, endPosition, Time.deltaTime * speed);
		} else {
			transform.position = Vector3.Lerp (transform.position, startPosition, Time.deltaTime * speed);
		}
	}
}