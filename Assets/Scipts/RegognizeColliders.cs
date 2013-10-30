/*using UnityEngine;
using System.Collections;

public class RegognizeColliders : MonoBehaviour {
	
	private bool isGrounded;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	//Checking to see if the enemies are touching the ground or not. 
	//If not, them they cannot move until 
	void FixedUpdate() {
    	if (isGrounded)
       		rigidbody.velocity = desiredVelocity;
	}
	
	void OnCollisionEnter( Collision other ) {
    	if (other.collider.gameObject.name == "Terrain" ) 
     	  isGrounded = true;
	}
 
	void OnCollisionStay( Collision other ) {
   		 if (other.collider.gameObject.name == "Terrain" ) 
    		isGrounded = true;
	}
 
	void OnCollisionExit( Collision other ) {
   	 	if (other.collider.gameObject.name == "Terrain" ) 
    		isGrounded = false;
	}
}
*/