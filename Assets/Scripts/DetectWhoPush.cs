using UnityEngine;
using System.Collections;


public class DetectWhoPush: MonoBehaviour {


	void OnCollisionEnter(Collision collision) {

		Physics.IgnoreCollision(collision.gameObject.collider,this.collider);
		collision.gameObject.tag = "afP";

	}


}