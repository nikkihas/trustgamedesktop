// Obselete! Use PlayAudioRespawn instead
// Modified by Rob on 13-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class PlayAudioCollision : MonoBehaviour {
	private float playAudio = 0;
	public AudioSource audioFile01;
	public AudioSource audioFile02;
	public AudioSource audioFile03;
	// Add more if necessary

	// Use this for initialization
	void Start () {
		AudioSource[] source = GetComponents<AudioSource> ();
		audioFile01 = source [0];
		audioFile01 = source [1];
		audioFile01 = source [2];
	}

	// Update is called once per frame
	void Update () {
		// Play an audio clip when the player collides with the object
		if (playAudio == 1) {
			playAudio++;
			audioFile01.Play ();
		}
		if (playAudio == 3) {
			playAudio++;
			audioFile01.Play ();
		}
		if (playAudio == 5) {
			playAudio++;
			audioFile01.Play ();
		}
	}

	// Add one to value the when the player collides with the object
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Player") {
			playAudio++;
		}
	}
}