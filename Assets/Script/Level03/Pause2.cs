using UnityEngine;
using System.Collections;

public class Pause2 : MonoBehaviour
{

	private float pauseUntil;
	private bool paused;

	void Update ()
	{
		if (paused)
			CheckPause ();
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			PauseForDuration (2.0f);
		}
	}

	void PauseForDuration (float duration)
	{
		paused = true;
		pauseUntil = Time.realtimeSinceStartup + duration;
		Time.timeScale = 0.0f;
	}

	void CheckPause ()
	{
		if (Time.realtimeSinceStartup >= pauseUntil) 
		{
			Time.timeScale = 1.0f;
			paused = false;
		}
	}
}


//if (Time.timeScale == 1) //if not paused
//	Time.timeScale = 0; //pause game
//else
//	Time.timeScale = 1; //otherwise resume