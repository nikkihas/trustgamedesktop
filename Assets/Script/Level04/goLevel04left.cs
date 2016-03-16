using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class goLevel04left : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) {
		SceneManager.LoadScene ("Level04left");
	}
}