import UnityEngine.SceneManagement;

var guiSkin: GUISkin;
  
function OnGUI () {
	

	GUI.skin = guiSkin;
	GUI.Box (Rect (0, 0, Screen.width/2, Screen.height), "GAME OVER", "centerMessage");
	// Where to begin Width, Where to begin Height, Size Width, Size Height 
	// Player 2
	GUI.Box (Rect (Screen.width/2, 0, Screen.width/2, Screen.height), "GAME OVER", "centerMessage");



}