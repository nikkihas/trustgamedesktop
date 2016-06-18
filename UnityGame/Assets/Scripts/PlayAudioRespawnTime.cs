// Merge with PlayAudioCollisionTime!

// Modified by Rob on 15-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class PlayAudioRespawnTime : MonoBehaviour {
	private bool playAudio = false;
	private bool audioIsPlayed = false;
	public float triggerTime = 5;

	// Update is called once per frame
	public void Update() {
		// Play an audio clip when Charlie has been respawned for a specific amount of times and after a specific amount of seconds
		if (RespawnTimer.time >= triggerTime && audioIsPlayed == false) {
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
		yield return new WaitForSeconds(0.5F);
		playAudio = true;
	}
}