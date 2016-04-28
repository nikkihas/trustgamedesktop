using UnityEngine;
using System.Collections;

public class rOpenBridge1 : MonoBehaviour
{
	public float speed = 1.0F;
	private bool down = false;
	private Quaternion startRot;
	private Quaternion endRot;

	void Start ()
	{
		startRot = Quaternion.Euler (new Vector3 (60, 0, 0));
		endRot = Quaternion.Euler (new Vector3 (0, 0, 0));
	}

	void Update ()
	{
		if (Input.GetButtonDown ("1")) {
			down = true;
		}


		if (Input.GetButtonUp ("1")) {
			down = false;
		}

		if (down == true) {
			transform.rotation = Quaternion.Slerp (transform.rotation, endRot, Time.deltaTime);
		} else {
			transform.rotation = Quaternion.Slerp (transform.rotation, startRot, Time.deltaTime);
		}
	}
}