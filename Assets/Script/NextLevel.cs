﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {
	

	void OnTriggerEnter(Collider other) {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
}