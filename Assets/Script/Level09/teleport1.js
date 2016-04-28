var target : Transform;
 
function Update () {
 
}
 
function OnTriggerEnter (col : Collider) {
 
        if(col.gameObject.tag == "ball1") {
                this.transform.position = target.position;
        }
}