// Modified and checked by Rob on 28-11-2016, please do not edit

using UnityEngine;
using System.Collections;

public class OpenLeftDoor : MonoBehaviour {
	private Vector3 startPosition;
	private Vector3 targetPosition;
	public float distance = 0.05F;
	public float speed = 2.0F;

	// Use this for initialization
	void Start () {
		// Set the start position
		startPosition = transform.position;
	}

	// Update is called once per frame
	void Update () {
		// Move the door with a specified distance
		if (DoorController.openLeftDoor == true) {
			targetPosition = transform.position - new Vector3 (distance, 0, 0);
			// Reset the boolean
			DoorController.openLeftDoor = false;
		}
		// Return the door to the start position
		if (DoorController.timesPressed == 0) {
			targetPosition = startPosition;
		}
		// Move the door to the target position
		transform.position = Vector3.Lerp (transform.position, targetPosition, Time.deltaTime * speed);
	}
}