using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class playDontMove : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		GetComponent<AudioSource>().Play();
	}

	void OnTriggerExit () {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
}
