// Modified and checked by Rob on 20-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class PlayAudioTime : MonoBehaviour {
	private bool playAudio = false;
	public float delay = 1.0F;

	// Use this for initialization
	void Start() {
		// Start the coroutine
		StartCoroutine (waitForSeconds());
	}

	// Update is called once per frame
	public void Update() {
		// Play an audio clip after a specified amount of time
		if (playAudio == true) {
			// Stop the coroutine
			StopCoroutine ("waitForSeconds");
			// Play the audio clip
			GetComponent<AudioSource>().Play();
			// Reset the boolean
			playAudio = false;
		}
	}

	// Wait for a specified amount of time
	IEnumerator waitForSeconds() {
		yield return new WaitForSeconds(delay);
		playAudio = true;
	}
}