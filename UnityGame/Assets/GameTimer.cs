using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour {
	public static float timeLeft;
	public static bool timerStarted = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (timerStarted == true) {
			timeLeft -= Time.deltaTime;
		}
		if (timeLeft < 0) {
			SceneManager.LoadScene(7);
		}
	}

	void OnGUI(){
		string minutes = Mathf.Floor(timeLeft / 60).ToString("00");
		string seconds = Mathf.Floor(timeLeft % 60).ToString("00");

		GUI.Label(new Rect(20, 20, 100, 20), minutes + ":" + seconds);
		GUI.Label(new Rect(400, 20, 100, 20), minutes + ":" + seconds);
	}
}
