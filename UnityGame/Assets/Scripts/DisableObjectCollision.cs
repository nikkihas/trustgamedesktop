// Modified by Rob on 06-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class DisableObjectCollision : MonoBehaviour {
	
	// Temporary disable the mesh collider when Charlie collides with the object
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Player") {
			GameObject.Find ("Invisible").GetComponent<MeshCollider> ().enabled = false;
			// Start the coroutine
			StartCoroutine (waitForSeconds());
		}
	}
	// Wait for a number of seconds
	IEnumerator waitForSeconds() {
		yield return new WaitForSeconds(5.0F);
		GameObject.Find ("Invisible").GetComponent<MeshCollider> ().enabled = true;
	}
}