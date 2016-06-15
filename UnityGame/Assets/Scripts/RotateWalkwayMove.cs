// Modified by Rob on 15-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class RotateWalkwayMove : MonoBehaviour {
	private Quaternion startRotation;
	private Quaternion endRotation;
	private bool openWalkway = false;
	public float rotationDistance = 45;
	public float speed = 3.0F;
	public bool forbiddenToMove = false;

	// Use this for initialization
	void Start () {
		// Set the start and end rotation of the walkway
		startRotation = transform.rotation;
		endRotation = Quaternion.Euler (0, 0, rotationDistance);
	}

	// Update is called once per frame
	void Update () {
		// Check if the light is red
		if (GameObject.Find ("IndicatorLight01").GetComponent<IndicatorLight01> ().indicatorIsRed == true) {
			StartCoroutine (waitForSeconds ());
		} else {
			// Reset the boolean
			forbiddenToMove = false;
			// Stop the coroutine
			StopCoroutine ("waitForSeconds");
		}
		// Open the walkway when Charlie moves while he not allowed
		if (forbiddenToMove == true && Input.GetAxis ("Vertical") != 0) {
			openWalkway = true;
		}
		if (openWalkway == true) {
			transform.rotation = Quaternion.Slerp (transform.rotation, endRotation, Time.deltaTime * speed);
			StartCoroutine (closeWalkway ());
		} else {
			// Stop the coroutine
			StopCoroutine ("closeWalkway");
		}
	}

	// Wait for a number of seconds
	IEnumerator waitForSeconds() {
		yield return new WaitForSeconds (1.0F);
		forbiddenToMove = true;
	}

	// Close the walkway after a number of seconds
	IEnumerator closeWalkway() {
		yield return new WaitForSeconds (5.0F);
		transform.rotation = Quaternion.Slerp (transform.rotation, startRotation, Time.deltaTime * speed);
		// Reset the boolean
		openWalkway = false;
	}
}