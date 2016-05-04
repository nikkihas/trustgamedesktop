var distToGround: float;
var jumpSpeed: float = 8;

function Start(){
	// get the distance to ground
	distToGround = GetComponent.<Collider>().bounds.extents.y;
}
 
function IsGrounded(): boolean {
	return Physics.Raycast(transform.position, -Vector3.up, distToGround + -0.1);
}
 
function Update () {
	if (Input.GetKeyDown(KeyCode.Space) && IsGrounded()){
	GetComponent.<Rigidbody>().velocity.y = jumpSpeed;
	}
}