// Modified and checked by Rob on 29-06-2016, please do not edit
// Edited Nikki 29-06-16

using UnityEngine;
using System.Collections;

public class RotateHitboxInput : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		// Rotate the object when a button is pressed while Charlie is in the hitbox	
		if (Input.GetButtonDown ("2") && NextLevelGlitch.playerInHitbox == true) {
			Debug.Log ("draai");
			transform.Rotate(0,30,0);
		}
	}
}