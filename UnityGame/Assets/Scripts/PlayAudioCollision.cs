// Modified by Rob on 18-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class PlayAudioCollision : MonoBehaviour {
	private bool playAudio = false;
	private bool audioIsPlayed = false;
	public static int timesCollided = 0;
	public int triggerAmount = 1;

	// Update is called once per frame
	public void Update() {
		// Play an audio clip when Charlie has collided with the object for a specific amount of times
		if (timesCollided == triggerAmount && audioIsPlayed == false) {
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

	// No comment!
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Player") {
			timesCollided++;
		}
	}

	// Wait for a number of seconds
	IEnumerator waitForSeconds() {
		yield return new WaitForSeconds(0.5F);
		playAudio = true;
	}
}