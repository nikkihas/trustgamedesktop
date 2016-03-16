using UnityEngine;
using System.Collections;


public class stopRotate2 : MonoBehaviour
{

	bool rotateObject = true;

	void Update ()
	{
		//movement
		if (rotateObject == true) {
			transform.Rotate (new Vector3 (0, 0, Time.deltaTime * 200));
		} else {
			transform.Rotate (new Vector3 (0, 0, 0));
		}


		//action
		if (Input.GetKey (KeyCode.J)) {
			StartCoroutine (DelayTime ());
		} else {
			rotateObject = true;
		}
	}


	// delay
	IEnumerator DelayTime ()
	{
		var waitTime = Random.Range(0.5f, 1.0f);
		yield return new WaitForSeconds (waitTime);
		Debug.Log ("waited 0,5 seconds");
		rotateObject = false;
	}
}