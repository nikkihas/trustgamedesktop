// Modified by Rob on 06-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour {
	public Vector3 startPosition = new Vector3 (11, 0, -19);
	public Vector3 endPosition = new Vector3 (-11,0, -19);
	public float speed = 0.5F;

	// Update is called once per frame
	void Update() {
		transform.position = Vector3.Lerp (startPosition, endPosition, (Mathf.Sin (speed * Time.time) + 1.0f) / 2.0f);
	}
}	