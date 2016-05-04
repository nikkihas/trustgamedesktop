using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class goLevel05 : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) {
		SceneManager.LoadScene ("Level05");
	}
}