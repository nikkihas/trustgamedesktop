// Modified by Rob on 18-06-2016, please do not edit
// Works with PlayAudioCollision script

using UnityEngine;
using System.Collections;

public class PlayAudioCollisionTime : MonoBehaviour {
	private bool playAudio = false;
	private bool audioIsPlayed = false;
	public int triggerAmount = 1;
	public float delay = 10.0F;

	// Update is called once per frame
	public void Update() {
		// Play an audio clip when Charlie has collided with the object for a specific amount of times
		if (PlayAudioCollision.timesCollided == triggerAmount && audioIsPlayed == false) {
			StartCoroutine (waitForSeconds ());
		}
		if (playAudio == true) {
			// Reset the boolean
			playAudio = false;
			// Stop the coroutine
			StopAllCoroutines ();
			GetComponent<AudioSource>().Play();
			// Set the boolean to true to prevent the audio clip form being played multiple times
			audioIsPlayed = true;
		}
	}

	// Wait for a number of seconds
	IEnumerator waitForSeconds() {
		yield return new WaitForSeconds(delay);
		playAudio = true;
	}
}