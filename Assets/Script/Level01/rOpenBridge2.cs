using UnityEngine;
using System.Collections;

public class rOpenBridge2 : MonoBehaviour
{
	public float speed = 1.0F;
	private bool down = false;
	private Quaternion startRot;
	private Quaternion endRot;

	void Start ()
	{
		startRot = Quaternion.Euler (new Vector3 (300, 0, 0));
		endRot = Quaternion.Euler (new Vector3 (0, 0, 0));
	}

	void Update ()
	{
		if (Input.GetButtonDown ("2")) {
			down = true;
			StartCoroutine (randomCloseBridge ());
		}


		if (Input.GetButtonUp ("2")) {
			down = false;
		}

		if (down == true) {
			transform.rotation = Quaternion.Slerp (transform.rotation, endRot, Time.deltaTime);
		} else {
			transform.rotation = Quaternion.Slerp (transform.rotation, startRot, Time.deltaTime);
		}
	}

	IEnumerator randomCloseBridge ()
	{
		var waitTime = Random.Range(0.75f, 1.5f);
		yield return new WaitForSeconds (waitTime);
		down = false;
	}
}