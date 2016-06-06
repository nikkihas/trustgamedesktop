using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {


	void OnTriggerEnter(Collider other) {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}