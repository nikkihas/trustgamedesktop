using UnityEngine;
using System.Collections;

public class addForce2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody>().AddForce(0, -500, -800);
		GetComponent<Rigidbody>().useGravity = true;
	}
}
