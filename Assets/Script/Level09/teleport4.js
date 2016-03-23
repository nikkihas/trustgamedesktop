var target : Transform;
 
function Update () {
 
}
 
function OnTriggerEnter (col : Collider) {
 
        if(col.gameObject.tag == "ball4") {
                this.transform.position = target.position;
        }
}