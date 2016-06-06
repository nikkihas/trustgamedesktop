// Modified by Rob on 06-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class MoveWithObject : MonoBehaviour {

	// Make an object a child on collision
	void OnTriggerEnter (Collider col) {
		col.transform.parent = gameObject.transform;
	}

	// Remove an object as a child
	void OnTriggerExit (Collider col) {
		col.transform.parent = null;
	}
}
