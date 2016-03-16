using UnityEngine;
using System.Collections;

public class SlowDown : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		ThirdPersonController.movementSpeed = 2.5f;
	}

	void OnTriggerExit(Collider other) {
		ThirdPersonController.movementSpeed = 5.0f;
	}
}