using UnityEngine;
using System.Collections;

public class buttonDown : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		transform.Translate (0, 1, 0);
	}

	void OnTriggerExit(Collider other) {
		transform.Translate(0,-1,0);
	}
}

