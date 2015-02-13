using UnityEngine;
using System.Collections;
public class ConveyorBelt : MonoBehaviour {
	
	public float speed = 3.0f;
	public Vector3 direction;
	Vector3 CollectVecSpeed;
	Vector3 conveyorMove;
	void Start()
	{
		CollectVecSpeed = new Vector3(0,-5.0f,35.0f);
		conveyorMove = speed * direction;
		
	}
	void OnCollisionStay(Collision collision) {

		// Assign velocity based upon direction of conveyor belt
		// Ensure that conveyor mesh is facing towards its local Z-axis
		
		 

		Rigidbody rigidbody = collision.gameObject.rigidbody;
	//	rigidbody.AddForce(conveyorVelocity * direction);
		if(rigidbody.tag != "afP")
			rigidbody.velocity = conveyorMove;
	    else
		{
			rigidbody.velocity =  CollectVecSpeed;
			rigidbody.mass = 500;
		
		}
	}
	
}