// Edited by Nikki, 29-06-16 changed LoadScene to "End"

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour {
	public static float timeLeft;
	public static bool timerStarted = false;
	public GUIStyle style;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (timerStarted == true) {
			timeLeft -= Time.deltaTime;
		}
		if (timeLeft < 0) {
			SceneManager.LoadScene("End");
		}
	}

	void OnGUI(){

		GUI.skin.label = style;

		string minutes = Mathf.Floor(timeLeft / 60).ToString("00");
		string seconds = Mathf.Floor(timeLeft % 60).ToString("00");

		GUI.Label(new Rect(Screen.width/12, Screen.height/16*2, Screen.width/4 - Screen.width/20, Screen.height/16*4), minutes + ":" + seconds);
		GUI.Label(new Rect(Screen.width/24*13, Screen.height/16*2, Screen.width/4 - Screen.width/20, Screen.height/16*4), minutes + ":" + seconds);

	}
}
