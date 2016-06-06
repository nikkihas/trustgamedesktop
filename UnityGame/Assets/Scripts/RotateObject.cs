// Modified by Rob on 06-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {
	public float speed = 40.0F;

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, Time.deltaTime * speed, 0));
	}
}