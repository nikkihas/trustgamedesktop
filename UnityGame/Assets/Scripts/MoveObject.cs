// Modified by Rob on 06-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour {
	private Vector3 startPosition;
	private Vector3 endPosition;
	public float xDistance = 0;
	public float yDistance = 0;
	public float zDistance = 0;
	public float speed = 0.5F;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
		endPosition = startPosition + new Vector3 (xDistance, yDistance, zDistance);
	}

	// Update is called once per frame
	void Update() {
		transform.position = Vector3.Lerp (startPosition, endPosition, (Mathf.Sin (speed * Time.time) + 1.0f) / 2.0f);
	}
}