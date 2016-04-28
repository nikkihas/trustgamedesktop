using UnityEngine;
using System.Collections;

public class rStopRotate2 : MonoBehaviour
{
	bool rotateObject = true;
	float speed = 200;

	void Update ()
	{
		if (Input.GetButtonDown ("2")) {
			StartCoroutine (randomStopPlatform ());
		} 
		if (Input.GetButtonUp ("2")) {
			rotateObject = true;
		}

		if (rotateObject == false) {
			transform.Rotate (new Vector3 (0, 0, 0));
		} else {
			transform.Rotate (new Vector3 (0, 0, Time.deltaTime * speed));
		}
	}

	IEnumerator randomStopPlatform ()
	{
		var waitTime = Random.Range (0.5f, 1.0f);
		yield return new WaitForSeconds (waitTime);
		rotateObject = false;
	}
}