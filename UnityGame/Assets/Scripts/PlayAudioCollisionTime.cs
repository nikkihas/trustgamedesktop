// Modified and checked by Rob on 20-06-2016, please do not edit
// Works with PlayAudioCollisionSingle script

using UnityEngine;
using System.Collections;

public class PlayAudioCollisionTime : MonoBehaviour {
	private bool playAudio = false;
	private bool audioIsPlayed = false;
	public int triggerAmount = 1;
	public float delay = 10.0F;

	// Update is called once per frame
	public void Update() {
		// Play an audio clip after a specific amount of time, when Charlie has collided with the object for a specific amount of times
		if (PlayAudioCollisionSingle.timesCollided == triggerAmount && audioIsPlayed == false) {
			StartCoroutine (waitForSeconds ());
		}
		if (playAudio == true) {
			// Stop the coroutine
			StopCoroutine ("waitForSeconds");
			// Set the boolean to prevent the audio clip form being played multiple times
			audioIsPlayed = true;
			// Play the audio clip
			GetComponent<AudioSource>().Play();
			// Reset the boolean
			playAudio = false;
		}
	}

	// Wait for a number of seconds
	IEnumerator waitForSeconds() {
		yield return new WaitForSeconds(delay);
		playAudio = true;
	}
}