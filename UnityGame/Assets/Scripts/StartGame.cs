using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	void Start() {
		Time.timeScale = 0;
	}

	void Update() {
		if (Input.GetButtonDown ("start")) {
			Time.timeScale =1;
		}
//		else
//			Time.timeScale =0;
//		}
	}
}