// Modified by Rob on 13-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class PlayAudioTime : MonoBehaviour {
	private bool playAudio = false;
	public float delay = 1.0F;

	// Use this for initialization
	void Start () {
		// Start the coroutine
		StartCoroutine (waitForSeconds ());
	}

	// Update is called once per frame
	public void Update() {
		// Play an audio clip after an amount of time
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
		yield return new WaitForSeconds(delay);
		playAudio = true;
	}
}