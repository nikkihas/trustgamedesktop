using UnityEngine;
using System.Collections;

public class speedDown2 : MonoBehaviour {

		void OnTriggerEnter(Collider other) {
			//RigidBodyController.movementSpeed = 0.01f;
		}

		void OnTriggerExit(Collider other) {
			//RigidBodyController.movementSpeed = 0.075f;
		}
	}