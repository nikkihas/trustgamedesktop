using UnityEngine;
using System.Collections;

public class StartSoundAfter : MonoBehaviour {

	public float time = 30f; //30 seconds for you

	public void Update()
	{
		if (time > 0) {
			time -= Time.deltaTime;
			GetComponent<AudioSource>().Play();
		}
		else {
			Debug.Log("Timer over play audio!");
		}


	}
}