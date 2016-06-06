// Modified by Rob on 06-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class DestroyObjectCollision : MonoBehaviour {
	
	// Destroy a mesh collider when the player on collision
	void OnTriggerEnter (Collider col) {
		if(col.gameObject.tag == "Player") {
			Destroy(GameObject.Find ("Invisible"));
		}
	}
}