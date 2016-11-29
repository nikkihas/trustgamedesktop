// Modified by Rob on 28-11-2016, please do not edit

using UnityEngine;
using System.Collections;

public class DestroyStart : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("start")) {
			// Destroy the game object
			Destroy(gameObject);
		}
	}
}