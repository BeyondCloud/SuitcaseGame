using UnityEngine;
using System.Collections;
public class ConveyorBelt : MonoBehaviour {
	
	public float speed = 3.0f;
	public Vector3 direction;
	Vector3 CollectVecSpeed;
	float conveyorVelocity;
	void Start()
	{
		CollectVecSpeed = new Vector3(0,-5.0f,35.0f);
		conveyorVelocity = speed * Time.deltaTime;
		
	}
	void OnCollisionStay(Collision collision) {

		// Assign velocity based upon direction of conveyor belt
		// Ensure that conveyor mesh is facing towards its local Z-axis
		
		 

		Rigidbody rigidbody = collision.gameObject.rigidbody;
	//	rigidbody.AddForce(conveyorVelocity * direction);
		if(rigidbody.tag != "afP")
		rigidbody.velocity = conveyorVelocity * direction;
	    else
		{
			rigidbody.velocity =  CollectVecSpeed;
			rigidbody.mass = 500;
		
		}
	}
	
}