using UnityEngine;
using System.Collections;

public class OpenBridgeMouse : MonoBehaviour
{
	//private GameObject bridge;
	public Transform bridge;
	private bool down = false;
	public float speed = 1.0F;
	private float pos = 0;
	private Quaternion startRot;
	private Quaternion endRot;
	// Use this for initialization

	void OnMouseDown ()
	{
		down = true;
	}

	void Start ()
	{
		
		endRot = Quaternion.Euler (new Vector3 (0, 0, 0));
		startRot = bridge.transform.rotation;
	}

	void FixedUpdate ()
	{
		if (down == true) {
			//bridge = GameObject.Find ("Bridge_Left");
			pos += speed / 10;
			bridge.transform.rotation = Quaternion.Slerp (startRot, endRot, pos);
		}
	}
}
