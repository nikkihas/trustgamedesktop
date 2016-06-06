using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) {
		Debug.Log ("Collide");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
}