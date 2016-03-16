using UnityEngine;
using System.Collections;


public class stopRotate1 : MonoBehaviour {

	bool rotateObject = true;
	//private float delay = 2.0f;
	//public float delay_set = 2.0f;

	void Update ()
	{
		if (rotateObject == true) {
			transform.Rotate (new Vector3 (0, 0, Time.deltaTime * 200));
		} 
		else 
		{
			transform.Rotate (new Vector3 (0, 0, 0));
		}


		if(Input.GetKey(KeyCode.H)) //|| delay > 0.0f) 
		{
			rotateObject = false;
		} 
		else 	
		{
			rotateObject = true;
		}
	}

//	void stopRotateH
//	{
//		if(Input.GetKey(KeyCode.H))
//			Starttimer
//			if timer == 3 seconden
//			rotateObject = true;
//	}
}