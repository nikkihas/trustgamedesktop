using UnityEngine;
using System.Collections;

public class destroyBall1 : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if(other.tag == "ball") {
			Destroy(other.gameObject);
		}
	}
}