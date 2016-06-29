// Modified by Rob on 13-05-2016, please do not edit

using UnityEngine;
using System.Collections;

public class RigidbodyController : MonoBehaviour {
	public bool grounded = false;
	public Rigidbody rb;
	public static Vector3 startPosition;
	public static Quaternion startRotation;
	public static float movementSpeed;
	public static float rotationSpeed;
	public float jumpSpeed = 8.0F;
	public bool allowedToJump = false;
	public static int timesRespawned;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		// Set Charlie's start position and rotation
		startPosition = transform.position;
		startRotation = Quaternion.identity;
		// Set Charlie's movement and rotation speed
		movementSpeed = 0.05F;
		rotationSpeed = 1.0F;
		// Reset the respawn counter
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
		if (Input.GetButtonDown ("2") && allowedToJump == true && grounded == true) {
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
			// Start the courotine
			StartCoroutine (fadeScreen());
		}
	}

	// Fade the screen to black and reset Charlie's position
	IEnumerator fadeScreen() {
		float fadeTime =  GameObject.Find("GameManager").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds(fadeTime);
		// Reset Charlie's position
		transform.position = startPosition;
		transform.rotation = startRotation;
		// Subtract an amount of time from the game time
		GameTimer.timeLeft -= 10.0F;
		// Increment the amount of times respawned
		timesRespawned++;
		// Fade the sceen from black to normal
		yield return new WaitForSeconds(1.0F);
		GameObject.Find("GameManager").GetComponent<Fading>().BeginFade(-1);
	}
}