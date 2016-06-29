// Modified and checked by Rob on 29-06-2016, please do not edit

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelGlitch : MonoBehaviour {
	private int timesPressed = 0;
	public float delay = 1.0F;
	public static bool playerInHitbox;

	// Use this for initialization
	void Start() {
		// Set the boolean
		playerInHitbox = false;
	}

	// Update is called once per frame
	void Update() {
		// Check if the button is pressed
		if (Input.GetButtonDown ("2")) {
			// Increment the variable
			timesPressed++;
		}
	}

	void OnTriggerExit (Collider col) {
		// Load the next level when Charlie exits the object and the button has been pressed the required amount of times
		if (col.gameObject.tag == "Player" && timesPressed > 20) {
			// Set Charlie's movement and rotation speed to zero to prevent him from moving
			RigidbodyController.movementSpeed = 0.0F;
			RigidbodyController.rotationSpeed = 0.0F;
			// Stop the audio
			GameObject.Find ("VoiceOverLoop").GetComponent<AudioSource>().Stop();
			// Start the coroutine
			StartCoroutine (fadeScreen ());
		}
		// Stop the audio when Charlie exits the object
		if (col.gameObject.tag == "Player") {
			// Reset the boolean
			playerInHitbox = false;
			// Stop the audio
			GameObject.Find ("VoiceOverLoop").GetComponent<AudioSource>().Stop();
		}
	}

	// Start the audio when Charlie re-enters the object
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Player" && PlayAudioCollision.timesCollided > 0) {
			// Re-start the audio
			GameObject.Find ("VoiceOverLoop").GetComponent<AudioSource>().Play();
		}
		if (col.gameObject.tag == "Player") {
			// Reset the value
			timesPressed = 0;
			// Set the boolean
			playerInHitbox = true;
		}
	}

	// Fade the screen to black
	IEnumerator fadeScreen() {
		float fadeTime =  GameObject.Find("GameManager").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds(fadeTime);
		yield return new WaitForSeconds(delay);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
}