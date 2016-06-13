// Modified by Rob on 13-05-2016, please do not edit

using UnityEngine;
using System.Collections;

public class SpeedDown : MonoBehaviour {
	
	public float defaultMovementSpeed = 0.05F;
	public float newMovementSpeed = 0.005F;

	// Set Charlie's movement speed to a new value
	void OnTriggerEnter (Collider col) {
		RigidbodyController.movementSpeed = newMovementSpeed;
	}

	// Reset Charlie's movement speed back to the default value
	void OnTriggerExit (Collider col) {
		RigidbodyController.movementSpeed = defaultMovementSpeed;
	}
}