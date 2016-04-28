  function OnTriggerStay(other:Collider){
             Debug.Log ("Move");
             if(other.gameObject.tag == "move"){
             transform.parent = other.transform;
 
         }
     }
 
 function OnTriggerExit(other:Collider){
     if(other.gameObject.tag == "move"){
             transform.parent = null;
             
         }
     }    