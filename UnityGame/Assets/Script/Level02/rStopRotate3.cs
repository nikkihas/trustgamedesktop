using UnityEngine;
using System.Collections;

public class rStopRotate3 : MonoBehaviour
{
	bool rotateObject = true;
	float speed = 200;

	void Update ()
	{
		if (Input.GetButtonDown ("3")) {
			StartCoroutine (randomStopPlatform ());
		} 
		if (Input.GetButtonDown ("3")) {
			rotateObject = true;
		}

		if (rotateObject == false) {
			transform.Rotate (new Vector3 (0, 0, 0));
			StartCoroutine (randomStartPlatform ());
		} else {
			transform.Rotate (new Vector3 (0, 0, Time.deltaTime * speed));
		}
	}

	IEnumerator randomStopPlatform ()
	{
		var waitTime = Random.Range (1f, 2f);
		yield return new WaitForSeconds (waitTime);
		rotateObject = false;
	}

	IEnumerator randomStartPlatform ()
	{
		var waitTime = Random.Range (1f, 2f);
		yield return new WaitForSeconds (waitTime);
		rotateObject = true;
	}
}