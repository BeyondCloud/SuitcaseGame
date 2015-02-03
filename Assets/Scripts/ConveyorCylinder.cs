using UnityEngine;
using System.Collections;

public class ConveyorCylinder : MonoBehaviour {
	
	public float speed = 3.0f;
	Vector3 thisToBox;

	void OnCollisionStay(Collision collision) {
		

		Rigidbody rigidbody = collision.gameObject.rigidbody;
		thisToBox = rigidbody.transform.position - transform.position;
		thisToBox.y = 0;
		thisToBox.z = - thisToBox.z;
		rigidbody.velocity = thisToBox;
	}
	
}