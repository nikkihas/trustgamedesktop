using UnityEngine;
using System.Collections;

public class SpeedUp : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		ThirdPersonController.movementSpeed = 8.0f;
	}

	void OnTriggerExit(Collider other) {
		ThirdPersonController.movementSpeed = 5.0f;
	}
}