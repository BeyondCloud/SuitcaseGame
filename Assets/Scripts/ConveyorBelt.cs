using UnityEngine;
using System.Collections;
public class ConveyorBelt : MonoBehaviour {
	
	public float speed = 3.0f;
	public Vector3 direction;
	void Start()
	{
		float conveyorVelocity = speed * Time.deltaTime;
		
	}
	void OnCollisionStay(Collision collision) {

		// Assign velocity based upon direction of conveyor belt
		// Ensure that conveyor mesh is facing towards its local Z-axis
		
		float conveyorVelocity = speed * Time.deltaTime;
		
		Rigidbody rigidbody = collision.gameObject.rigidbody;
	//	rigidbody.AddForce(conveyorVelocity * direction);
		if(rigidbody.tag != "afP")
		rigidbody.velocity = conveyorVelocity * direction;
	    else
		rigidbody.velocity = conveyorVelocity * Vector3.forward * 3.0f;
	}
	
}