using UnityEngine;
using System.Collections;

public class ThirdPersonController : MonoBehaviour
{

	static public float movementSpeed = 5.0f; //5.0f on Keyboard
	static public float turnSensitivity = 1.5f; //2.0f on Keyboard

	// Use this for initialization
	void Start ()
	{
		//Screen.lockCursor = true;
	}

	// Update is called once per frame
	void Update ()
	{
		//rotation

		float rotLeftRight = Input.GetAxis ("Horizontal") * turnSensitivity;
		transform.Rotate (0, rotLeftRight, 0);

		//movement
		float forwardSpeed = Input.GetAxis ("Vertical") * movementSpeed;

		Vector3 speed = new Vector3 (0, 0, forwardSpeed);

		speed = transform.rotation * speed;

		CharacterController cc = GetComponent<CharacterController> ();

		cc.SimpleMove (speed);
	}
}
