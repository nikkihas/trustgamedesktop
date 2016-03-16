using UnityEngine;
using System.Collections;

public class OpenBridge2 : MonoBehaviour
{
	private bool down = false;
	public float speed = 1.0F;
	private float pos = 0;
	private Quaternion startRot;
	private Quaternion endRot;
	// Use this for initialization


	void Start ()
	{

		endRot = Quaternion.Euler (new Vector3 (0, 0, 0));
		startRot = transform.rotation;
	}



	void Update ()
	{
		if (Input.GetKey (KeyCode.J)) 
		{
			down = true;
		}

		if (down == true) {
			pos += speed / 100;
			transform.rotation = Quaternion.Slerp (startRot, endRot, pos);
		} 
	}
}