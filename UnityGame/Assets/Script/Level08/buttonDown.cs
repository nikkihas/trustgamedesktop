using UnityEngine;
using System.Collections;

public class buttonDown : MonoBehaviour {

	public Material LightOff;
	public Material LightOn;

//	void Start () {
//		GetComponent<AudioSource>().Stop();
//	}

	void OnTriggerEnter(Collider other) {
		//transform.Translate (0, 1, 0);
		gameObject.GetComponent<Renderer>().material = LightOn;
		GetComponent<AudioSource>().Play();

	}

	void OnTriggerExit(Collider other) {
		//transform.Translate(0,-1,0);
		gameObject.GetComponent<Renderer>().material = LightOff;
	}			
}

