// Modified and checked by Rob on 29-11-2016, please do not edit

using UnityEngine;
using System.Collections;

public class SubtitlesRespawn : MonoBehaviour {
	private bool visible;
	private bool subtitlesAreDisplayed;
	public GUIStyle style;
	public string lineOne = "Line 1!";
	public string lineTwo = "Line 2!";
	public int triggerAmount = 1;
	public float delay = 0;
	public float time = 2;


	// Use this for initialization
	void Start() {
		// Set the boolean
		subtitlesAreDisplayed = false;
	}

	// Update is called once per frame
	void Update () {
		if (RigidbodyController.timesRespawned == triggerAmount && subtitlesAreDisplayed == false) {
			// Set the boolean to prevent the subtitles from being displayed multiple times
			subtitlesAreDisplayed = true;
			// Hide the text after a specified amount of time
			Invoke ("DisplayText", delay);
			Invoke ("HideText", delay + time);
		}
	}

	// Set the boolean to true
	void DisplayText () {
		visible = true;
	}

	// Set the boolean to false
	void HideText () {
		visible = false;
	}

	void OnGUI() {
		if (visible) {
			GUI.skin.label = style;
			// Display the time on the interface
			GUI.Label(new Rect(Screen.width/12, Screen.height/16*13, Screen.width/24*9, Screen.height/10), lineOne);
			GUI.Label(new Rect(Screen.width/12, Screen.height/16*14, Screen.width/24*9, Screen.height/10), lineTwo);
			GUI.Label(new Rect(Screen.width/24*13, Screen.height/16*13, Screen.width/24*9, Screen.height/10), lineOne);
			GUI.Label(new Rect(Screen.width/24*13, Screen.height/16*14, Screen.width/24*9, Screen.height/10), lineTwo);
		}
	}
}