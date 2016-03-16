using UnityEngine;
using System.Collections;

public class TimeTotal : MonoBehaviour {

	public GUISkin totalTimeGUI;

	public static float timer;
	public static bool timeStarted = true;

	void Awake() 
	{
		DontDestroyOnLoad(transform.gameObject);
	}
		

	void Update()
	{
		if (timeStarted == true) {
			timer += Time.deltaTime;
		}   
	}

	void OnGUI () 
	{
		GUI.skin = totalTimeGUI;

		int minutes = Mathf.FloorToInt(timer / 60F);
		int seconds = Mathf.FloorToInt(timer - minutes * 60);
		string totalTime = string.Format("{00:00}:{1:00}", minutes, seconds);


		GUI.Box(new Rect(Screen.width/16, Screen.height/16*2, Screen.width/16*4, Screen.height/16*2), totalTime);
		GUI.Box(new Rect(Screen.width/16*9, Screen.height/16*2, Screen.width/16*4, Screen.height/16*2), totalTime);
	}
}