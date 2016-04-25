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
		RigidBodyController.movementSpeed = 0.025f;
	}

	void OnTriggerExit(Collider other) {
		RigidBodyController.movementSpeed = 0.1f;
		Destroy (gameObject);
	}
}