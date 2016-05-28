// Modified by Rob on 27-05-2016, please do not edit

using UnityEngine;
using System.Collections;

public class LowerPlatform1 : MonoBehaviour {
	private bool down = false;
	public Vector3 startPosition;
	public Vector3 endPosition;
	public float speed = 2.0F;

	// Use this for initialization
	void Start () {
		startPosition = new Vector3 (0, 4, 2);
		endPosition = new Vector3 (0, -1, 2);
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
			transform.position = Vector3.Lerp(transform.position, endPosition, Time.deltaTime);
		} else {
			transform.position = Vector3.Lerp(transform.position, startPosition, Time.deltaTime);
		}
	}
}