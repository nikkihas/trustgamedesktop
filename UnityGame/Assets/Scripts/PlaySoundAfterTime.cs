// Modified by Rob on 13-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class PlaySoundAfterTime : MonoBehaviour {
	private bool playAudio = false;
	public float timer = 2.0F;

	// Update is called once per frame
	public void Update() {
		// Start the coroutine
		StartCoroutine (waitForSeconds ());

		// Play sound when the timer has reached zero
		if (playAudio == true) {
			// Reset the boolean
			playAudio = false;
			// Stop the coroutine
			StopAllCoroutines ();
			GetComponent<AudioSource>().Play();
		}
	}

	// Wait for a number of seconds
	IEnumerator waitForSeconds() {
		yield return new WaitForSeconds(0.5F);
		playAudio = true;
	}
}