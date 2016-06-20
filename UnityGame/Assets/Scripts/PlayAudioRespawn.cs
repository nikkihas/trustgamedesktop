// Modified and checked by Rob on 20-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class PlayAudioRespawn : MonoBehaviour {
	private bool playAudio = false;
	private bool audioIsPlayed = false;
	public int triggerAmount = 1;

	// Update is called once per frame
	public void Update() {
		// Play an audio clip when Charlie has been respawned for a specific amount of times
		if (RigidbodyController.timesRespawned == triggerAmount && audioIsPlayed == false) {
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
		yield return new WaitForSeconds(1.0F);
		playAudio = true;
	}
}