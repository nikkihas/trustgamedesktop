using UnityEngine;
using System.Collections;


public class stopRotate3 : MonoBehaviour
{

	bool rotateObject = true;
 
	void Update ()
	{
		if (rotateObject == true) {
			transform.Rotate (new Vector3 (0, 0, Time.deltaTime * 200));
		} else {
			transform.Rotate (new Vector3 (0, 0, 0));
		}


		if (Input.GetKey(KeyCode.K)) {
			StartCoroutine (DelayTime ());
		} else {
			rotateObject = true;
		}
	}

	IEnumerator DelayTime ()
	{
		var waitTime = Random.Range(0.75f, 1.5f);
		yield return new WaitForSeconds (waitTime);
		Debug.Log ("waited 0,5 seconds");
		rotateObject = false;
	}
}