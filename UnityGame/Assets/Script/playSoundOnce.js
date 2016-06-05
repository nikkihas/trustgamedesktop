#pragma strict

var hasPlayed = false;


 
function OnTriggerEnter(){
	if(!hasPlayed){
		GetComponent.<AudioSource>().Play();
		hasPlayed = true;
	}
}
