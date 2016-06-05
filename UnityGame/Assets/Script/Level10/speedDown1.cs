using UnityEngine;
using System.Collections;

public class speedDown1 : MonoBehaviour {
		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

		}

		void OnTriggerEnter(Collider other) {
			RigidBodyController.movementSpeed = 0.02f;
		}

		void OnTriggerExit(Collider other) {
			RigidBodyController.movementSpeed = 0.075f;
		}
	}