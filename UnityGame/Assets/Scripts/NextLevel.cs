// Modified by Rob on 18-06-2016, please do not edit

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	// Load the next level
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Player") {
			StartCoroutine (loadNextLevel ());
			// Set the movement speed to zero to prevent Charlie from moving
			RigidbodyController.movementSpeed = 0.0F;
		}
	}

	// Wait for a number of seconds
	IEnumerator loadNextLevel() {
		float fadeTime =  GameObject.Find ("_GM").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds(fadeTime);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
}