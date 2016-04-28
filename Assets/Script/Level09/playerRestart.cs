using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class playerTeleport1 : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if(other.tag == "Player") {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}