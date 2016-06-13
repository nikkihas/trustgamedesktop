// Modified by Rob on 13-05-2016, please do not edit

using UnityEngine;
using System.Collections;

public class RigidbodyController : MonoBehaviour {
	private bool grounded = false;
	public Rigidbody rb;
	public static float movementSpeed = 0.05F;
	public float rotationSpeed = 1.0F;
	public float jumpSpeed = 5.0F;
	public bool allowedToJump = false;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate () {
		// Make Charlie move
		float moveHorizontal = Input.GetAxis ("Horizontal") * rotationSpeed;
		float moveVertical = Input.GetAxis ("Vertical") * movementSpeed;

		transform.Rotate (0, moveHorizontal, 0);

		Vector3 movement = new Vector3 (0, 0, moveVertical);
		movement = transform.rotation * movement;

		rb.MovePosition (transform.position + movement); 

		// Make Charlie jump when he is grounded and when it is allowed
		if (Input.GetButtonDown ("2") && allowedToJump == true) {
			rb.velocity = new Vector3 (0, jumpSpeed, 0);
		}
		// Reset the boolean
		grounded = false;
	}
	// Check if Charlie is down to earth or high like a mothafucka!
	void OnCollisionStay () {
		grounded = true;    
	}
}