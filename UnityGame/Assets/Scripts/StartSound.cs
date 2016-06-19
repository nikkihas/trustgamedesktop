using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartSound : MonoBehaviour {

	void Update() {
		if (Input.GetButtonDown ("start")) {
			GetComponent<AudioSource>().Play();
		}
	}
}