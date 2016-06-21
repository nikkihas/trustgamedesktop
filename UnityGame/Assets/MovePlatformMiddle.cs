// Modified and checked by Rob on 20-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class MovePlatformMiddle : MonoBehaviour {
	private Vector3 startPosition;
	private Vector3 endPosition;
	public static bool move;
	public float distance = 20;
	public float speed = 2.0F;

	// Use this for initialization
	void Start() {
		// Reset the boolean
		move = false;
		// Set the start and end position
		startPosition = transform.position;
		endPosition = startPosition + new Vector3 (0, distance, 0);
	}

	// Update is called once per frame
	void Update() {
		// Move the platform to the start or end position
		if (move == true) {
			transform.position = Vector3.Lerp(transform.position, endPosition, Time.deltaTime * speed);
		} else {
			transform.position = Vector3.Lerp(transform.position, startPosition, Time.deltaTime * speed);
		}
	}
}