using UnityEngine;
using System.Collections;

public class SuitCaseRespawn : MonoBehaviour {

	public Transform startPoint;

		void OnCollisionEnter(Collision collision) {
			
		
			collision.rigidbody.transform.position = startPoint.position;
			
			
		}

}
