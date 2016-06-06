using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartLevelFake : MonoBehaviour {


	void OnTriggerEnter(Collider other) {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Destroy (gameObject);
	}
}