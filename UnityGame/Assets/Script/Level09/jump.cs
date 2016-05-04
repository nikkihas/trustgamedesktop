using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {

	public float jumpSpeed = 5f;//or whatever you want it to be
	public Rigidbody rb; //and again, whatever you want to call it

	void Start (){
		rb = GetComponent <Rigidbody>();
	}

	void FixedUpdate(){
		if(Input.GetKey (KeyCode.Space)){
			rb.AddForce(Vector3.up * jumpSpeed);
		}

	}
}