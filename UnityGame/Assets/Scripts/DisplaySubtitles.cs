// Modified by Rob on 28-11-2016, please do not edit

using UnityEngine;
using System.Collections;

public class DisplaySubtitles : MonoBehaviour {
	private bool visible;
	public GUIStyle style;
	public string text = "Hello world!";
	public float delay = 0;
	public float time = 5;

	// Use this for initialization
	void Start () {
		Invoke ("DisplayText", delay);
		Invoke ("HideText", delay + time);
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
			GUI.Label(new Rect(Screen.width/12, Screen.height/16*13, Screen.width/24*9, Screen.height/8), text);
			GUI.Label(new Rect(Screen.width/24*13, Screen.height/16*13, Screen.width/24*9, Screen.height/8), text);
		}

	}
}