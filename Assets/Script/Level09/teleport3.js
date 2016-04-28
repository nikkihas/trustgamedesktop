var target : Transform;
 
function Update () {
 
}
 
function OnTriggerEnter (col : Collider) {
 
        if(col.gameObject.tag == "ball3") {
                this.transform.position = target.position;
        }
}