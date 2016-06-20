// Rename to PlayAudioCollision
// Modified and checked by Rob on 20-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class PlayAudioCollisionSingle : MonoBehaviour {
	private bool playAudio = false;
	private bool audioIsPlayed = false;
	public static int timesCollided;

	// Use this for initialization
	void Start() {
		// Reset the counter
		timesCollided = 0;
	}

	// Update is called once per frame
	public void Update() {
		// Play an audio clip when Charlie collides with the object
		if (playAudio == true && audioIsPlayed == false) {
			// Set the boolean to prevent the audio clip form being played multiple times
			audioIsPlayed = true;
			// Play the audio clip
			GetComponent<AudioSource>().Play();
			// Reset the boolean
			playAudio = false;
		}
	}

	// Set the boolean when Charlie collides with the object
	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") {
			playAudio = true;
			timesCollided++;
		}
	}
}