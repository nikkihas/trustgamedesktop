 using UnityEngine;
using System.Collections;

public class RigidBodyController : MonoBehaviour {

	public static float movementSpeed = 0.1f;
	float turnSensitivity = 1.5f;
	public Rigidbody rig;

	// Use this for initialization
	void Start () {
		rig = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		// rotation
		float rotLeftRight = Input.GetAxis ("Horizontal") * turnSensitivity;
		transform.Rotate (0, rotLeftRight, 0);

		// forward
		float forwardSpeed = Input.GetAxis ("Vertical") * movementSpeed;

		Vector3 speed = new Vector3 (0, 0, forwardSpeed) ;

		speed = transform.rotation * speed;

		rig.MovePosition (transform.position + speed); 
	}
}