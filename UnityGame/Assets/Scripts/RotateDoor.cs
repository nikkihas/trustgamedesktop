// Modified and checked by Rob on 31-10-2016, please do not edit

using UnityEngine;
using System.Collections;

public class RotateDoor : MonoBehaviour {
	private Quaternion startRotation;
	private Quaternion targetRotation;
	public float degrees = 3;
	public float speed = 2.0F;

	// Use this for initialization
	void Start () {
		// Set the start position
		startRotation = transform.rotation;
	}

	// Update is called once per frame
	void Update () {
		// Rotate the door with a specified amount of degrees
		if (DoorController.openDoor == true) {
			targetRotation *= Quaternion.Euler (0, 0, degrees);
			// Reset the boolean
			DoorController.openDoor = false;
		}
		// Return the door to the start posistion
		if (DoorController.timesPressed == 0) {
			targetRotation = startRotation;
		}
		// Rotate the door to the target posisition
		transform.rotation = Quaternion.Slerp (transform.rotation, targetRotation, Time.deltaTime * speed);
	}
}
