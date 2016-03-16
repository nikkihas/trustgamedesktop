using UnityEngine;
using System.Collections;

public class addForce : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody>().AddForce(0, 0, 1000);
		GetComponent<Rigidbody>().useGravity = true;
	}
}
