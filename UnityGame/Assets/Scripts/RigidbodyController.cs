// Modified by Rob on 13-05-2016, please do not edit

using UnityEngine;
using System.Collections;

public class RigidbodyController : MonoBehaviour {
	private bool grounded = false;
	public Rigidbody rb;
	public static Vector3 startPosition;
	public static Quaternion startRotation;
	public static float movementSpeed = 0.05F;
	public float rotationSpeed = 1.0F;
	public float jumpSpeed = 8.0F;
	public bool allowedToJump = false;
	public static int timesRespawned;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		// Set Charlie's start position and rotation
		startPosition = transform.position;
		startRotation = Quaternion.Euler (0, 180, 0);
		timesRespawned = 0;
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

	// Send Charlie back to the start position when he dies
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Respawn") {
			transform.position = startPosition;
			transform.rotation = startRotation;
			timesRespawned++;
		}
	}
}