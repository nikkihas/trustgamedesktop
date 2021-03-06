﻿import UnityEngine.SceneManagement;

private var startTime : int;
private var restSeconds : int;
private var roundedRestSeconds : int;
private var displaySeconds : int;
private var displayMinutes : int;

var guiSkin: GUISkin;
var countDownSeconds : int;
  
function OnGUI () {
	//make sure that your time is based on when this script was first called
	//instead of when your game started
	var guiTime = Time.time - startTime;

	restSeconds = countDownSeconds - (guiTime);
	//display messages or whatever here -->do stuff based on your timer
	//if (restSeconds == 60) {
	//    print ("One Minute Left");
	//}
	if (restSeconds == 0) {
		//Application.LoadLevel(Application.loadedLevel);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	//display the timer
	roundedRestSeconds = Mathf.CeilToInt(restSeconds);
	displaySeconds = roundedRestSeconds % 60;
	displayMinutes = roundedRestSeconds / 60; 

	text = String.Format ("{0:00}:{1:00}", displayMinutes, displaySeconds);

	GUI.skin = guiSkin;
	GUI.Box (Rect (Screen.width/16, Screen.height/22, Screen.width/16*4, Screen.height/16*2), "TIME LEFT", "LevelTimerDescription");
	GUI.Box (Rect (Screen.width/16, Screen.height/16, Screen.width/16*4, Screen.height/16*2), text, "LevelTimer");
	// Where to begin Width, Where to begin Height, Size Width, Size Height 
	// Player 2
	GUI.Box (Rect (Screen.width/16*9, Screen.height/22, Screen.width/16*4, Screen.height/16*2), "TIME LEFT", "LevelTimerDescription");
	GUI.Box (Rect (Screen.width/16*9, Screen.height/16, Screen.width/16*4, Screen.height/16*2), text, "LevelTimer");

	// Total Time
	GUI.Box (Rect (Screen.width/16, Screen.height/9, Screen.width/16*4, Screen.height/16*2), "TOTAL TIME", "LevelTimerDescription");
	GUI.Box (Rect (Screen.width/16*9, Screen.height/9, Screen.width/16*4, Screen.height/16*2), "TOTAL TIME", "LevelTimerDescription");


}