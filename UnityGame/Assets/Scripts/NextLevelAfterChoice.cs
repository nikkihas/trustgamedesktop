using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelAfterChoice : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		StartCoroutine (StartNumerator ());
		//StopMovement
	}

	IEnumerator StartNumerator() {
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(10f);
		//Play sound Level04d
		//Fade to Black like all levels
		yield return new WaitForSeconds(7f);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
}