// Modified and checked by Rob on 31-10-2016, please do not edit

using UnityEngine;
using System.Collections;

public class RotateHitboxInput : MonoBehaviour {
	private Quaternion newRotation;
	private float rotationDistance;
	public float speed = 3.0F;

	// Use this for initialization
	void Start() {
		// Set the start and end rotation of the walkway
		newRotation = transform.rotation;
	}

	// Update is called once per frame
	void Update () {
		// Rotate the object when a button is pressed while Charlie is in the hitbox	
		if (Input.GetButtonDown ("2")) {
			// if (Input.GetButtonDown ("2") && NextLevelGlitch.playerInHitbox == true) {
			// Increment the rotation distance
			rotationDistance = rotationDistance + 30;
			// Set a new position
			newRotation = Quaternion.Euler (rotationDistance, 90, 90);
		}
		// Rotate the object to the new position
		transform.rotation = Quaternion.Slerp (transform.rotation, newRotation, Time.deltaTime * speed);
	}
}