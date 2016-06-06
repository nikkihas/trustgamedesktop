using UnityEngine;
using System.Collections;

public class speedDown2 : MonoBehaviour {
		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

		}

		void OnTriggerEnter(Collider other) {
			RigidBodyController.movementSpeed = 0.01f;
		}

		void OnTriggerExit(Collider other) {
			RigidBodyController.movementSpeed = 0.075f;
		}
	}