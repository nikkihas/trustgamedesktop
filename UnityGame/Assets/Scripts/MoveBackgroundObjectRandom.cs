// Modified by Rob on 31-10-2016, please do not edit

using UnityEngine;
using System.Collections;

public class MoveBackgroundObjectRandom : MonoBehaviour {
	private Vector3 startPosition;
	private Vector3 endPosition;
	private float distance;
	public float speed = 0.5F;

	// Use this for initialization
	void Start () {
		// Generate a random distance
		distance = Random.Range (2, 10);
		// Set the start position
		startPosition = transform.position;
		// Set the end position
		endPosition = startPosition + new Vector3 (0, distance, 0);
	}

	// Update is called once per frame
	void Update() {
		// Move the object from the start to the end position and back
		transform.position = Vector3.Lerp (startPosition, endPosition, (Mathf.Sin (speed * Time.time) + 1.0f) / 2.0f);
	}
}