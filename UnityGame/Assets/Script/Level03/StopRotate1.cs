using UnityEngine;
using System.Collections;

public class StopRotate1 : MonoBehaviour
{
	bool rotateObject = true;
	float speed = 200;

	void Update ()
	{
		if (Input.GetButtonDown ("2")) {
			rotateObject = false;
		} 
		if (Input.GetButtonUp ("2")) {
			rotateObject = true;
		}

		if (rotateObject == false) {
			transform.Rotate (new Vector3 (0, 0, 0));
			//StartCoroutine (randomStartPlatform ());

		} else {
			transform.Rotate (new Vector3 (0, 0, Time.deltaTime * speed));
		}
	}

	IEnumerator randomStartPlatform ()
	{
		var waitTime = Random.Range (3f, 4f);
		yield return new WaitForSeconds (waitTime);
		rotateObject = true;
	}
}