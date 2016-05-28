// Modified by Rob on 27-05-2016, please do not edit

using UnityEngine;
using System.Collections;

public class DestroyColliderMove : MonoBehaviour {
	public bool forbiddenToMove = false;
	public MeshCollider meshCollider;

	// Use this for initialization
	void Start () {
		meshCollider = GetComponent<MeshCollider> ();
	}

	// Update is called once per frame
	void Update () {
		// Destroy the mesh collider when the player moves while it not allowed
		if (GameObject.Find ("IndicatorLight01").GetComponent<IndicatorLight01> ().indicatorIsRed == true) {
			StartCoroutine (waitForSeconds ());
		} else {
			// Reset the boolean
			forbiddenToMove = false;
			// Stop the coroutine
			StopAllCoroutines ();
		}
		// Destroy the mesh collider when the player moves while it is not allowed
		// Change to allow the player to look around
		if (forbiddenToMove == true && Input.anyKey == true) {
			Destroy (meshCollider);
		}
	}

	// Wait for a number of seconds
	IEnumerator waitForSeconds() {
		yield return new WaitForSeconds(0.5F);
		forbiddenToMove = true;
	}
}