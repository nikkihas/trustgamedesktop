// Modified by Rob on 15-06-2016, please do not edit

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetPositionHitbox : MonoBehaviour {
	private bool playAudio = false;

	// Update is called once per frame
	public void Update() {
		// Play an audio clip and reset Charlie's position when he collides with the object
		if (playAudio == true) {
			// Reset the boolean
			playAudio = false;
			// Stop the coroutine
			StopCoroutine ("waitForSeconds");
			// Play the audio clip
			GetComponent<AudioSource>().Play();
			// Start the coroutine
			StartCoroutine (destroyObject ());
		}
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") {
			// Start the coroutine
			StartCoroutine (waitForSeconds ());
		}
	}

	// Wait for a number of seconds
	IEnumerator waitForSeconds() {
		yield return new WaitForSeconds (0.5F);
		playAudio = true;
	}

	// Wait for a number of seconds
	IEnumerator destroyObject() {
		yield return new WaitForSeconds (10.0F);
		Destroy (gameObject);
	}
}