// Modified and checked by Rob on 20-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class ResetPositionHitbox : MonoBehaviour {
	private bool playAudio = false;

	// Update is called once per frame
	public void Update() {
		// Play an audio clip and reset Charlie's position when he collides with the object
		if (playAudio == true) {
			// Play the audio clip
			GetComponent<AudioSource>().Play();
			// Start the coroutine
			StartCoroutine (waitForSeconds ());
			// Reset the boolean
			playAudio = false;
		}
	}

	// Set the boolean and reset Charlie's position when he collides with the object
	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") {
			playAudio = true;
			GameObject.Find ("Player01").transform.position = RigidbodyController.startPosition;
			GameObject.Find ("Player01").transform.rotation = RigidbodyController.startRotation;
		}
	}

	// Wait for a number of seconds
	IEnumerator waitForSeconds() {
		yield return new WaitForSeconds (10.0F);
		Destroy (gameObject);
	}
}