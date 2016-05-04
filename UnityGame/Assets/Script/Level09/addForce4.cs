using UnityEngine;
using System.Collections;

public class addForce4 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody>().AddForce(0, -200, -1500);
		GetComponent<Rigidbody>().useGravity = true;
	}
}
