using UnityEngine;
using System.Collections;

public class addForce3 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody>().AddForce(0, 0, 250);
		GetComponent<Rigidbody>().useGravity = true;
	}
}
