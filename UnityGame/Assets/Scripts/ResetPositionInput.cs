// Modified and checked by Rob on 20-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class ResetPositionInput : MonoBehaviour {

	// Update is called once per frame
	public void Update() {
		// Reset Charlie's position when a button is pressed
		if (Input.GetButtonDown("2")) {
			transform.position = RigidbodyController.startPosition;
			transform.rotation = RigidbodyController.startRotation;
		}
	}
}