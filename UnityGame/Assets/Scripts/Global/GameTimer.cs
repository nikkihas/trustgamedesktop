// Modified and checked by Rob on 29-06-2016, please do not edit

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour {
	public GUIStyle style;
	public static float timeLeft;
	public static bool timerStarted = false;

	// Update is called once per frame
	void Update () {
		// Decrement the clock every second
		if (timerStarted == true) {
			timeLeft -= Time.deltaTime;
		}
		// Go to the final level when there is no time left
		if (timeLeft < 0) {
			SceneManager.LoadScene("End");
		}
	}

	void OnGUI(){
		GUI.skin.label = style;
		// Transform the value to minutes and seconds
		string minutes = Mathf.Floor(timeLeft / 60).ToString("00");
		string seconds = Mathf.Floor(timeLeft % 60).ToString("00");
		// Display the time on the interface
		GUI.Label(new Rect(Screen.width/12, Screen.height/16*2, Screen.width/4 - Screen.width/20, Screen.height/16*4), minutes + ":" + seconds);
		GUI.Label(new Rect(Screen.width/24*13, Screen.height/16*2, Screen.width/4 - Screen.width/20, Screen.height/16*4), minutes + ":" + seconds);
	}
}
