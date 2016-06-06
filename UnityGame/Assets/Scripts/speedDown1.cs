using UnityEngine;
using System.Collections;

public class speedDown1 : MonoBehaviour {


	public static int score;

		void OnTriggerEnter(Collider other) {
			//RigidbodyFPSController.speed = 1f;
		}

		void OnTriggerExit(Collider other) {
			//RigidbodyFPSController.speed = 2.5f;
		}
	}