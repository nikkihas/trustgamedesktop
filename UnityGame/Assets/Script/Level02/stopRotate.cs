using UnityEngine;
using System.Collections;


public class stopRotate : MonoBehaviour {

	bool rotateObject = true;
	// Update is called once per frame
	void Update () {
		
		if (rotateObject == true)
		{
			transform.Rotate (new Vector3 (0, 0, Time.deltaTime * 200));
		}
		else 
		{
			transform.Rotate (new Vector3 (0, 0, 0));
		}
	}

	// Stop Rotation on Hover
	void OnMouseOver ()
	{
		rotateObject = false;
	}﻿

	// Start Rotation
	void OnMouseExit ()
	{
		rotateObject = true;
	}﻿
}