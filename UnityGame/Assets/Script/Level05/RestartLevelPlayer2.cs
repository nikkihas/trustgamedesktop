using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartLevelPlayer2 : MonoBehaviour {


	void Update() {
		if (Input.GetButtonDown ("2")) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}