var toggleGUI : boolean;
var guiSkin: GUISkin;

function Start() { 
 	toggleGUI = false;
}

function OnTriggerEnter (other : Collider) {
	toggleGUI = true;
	yield WaitForSeconds(2);
	Destroy(gameObject);
}
  
function OnGUI () { 	
	if (toggleGUI == true){
		GUI.skin = guiSkin;
		GUI.Box(Rect(Screen.width/16*2, Screen.height/3, Screen.width/16*4, Screen.height/16*2), "Player 2 Killed You", "centerMessage");
	}
}
