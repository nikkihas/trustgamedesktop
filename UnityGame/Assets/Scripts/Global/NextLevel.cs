// Modified and checked by Rob on 29-06-2016, please do not edit

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {
	public float delay = 1.0F;

	// Load the next level when Charlie collides with the object
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Player") {
			// Set Charlie's movement and rotation speed to zero to prevent him from moving
			RigidbodyController.movementSpeed = 0.0F;
			RigidbodyController.rotationSpeed = 0.0F;
			// Start the coroutine
			StartCoroutine (fadeScreen ());
		}
	}

	// Fade the screen to black and load the next level
	IEnumerator fadeScreen() {
		float fadeTime =  GameObject.Find("GameManager").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds(fadeTime);
		yield return new WaitForSeconds(delay);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
}