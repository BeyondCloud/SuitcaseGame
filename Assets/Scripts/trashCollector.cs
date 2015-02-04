using UnityEngine;
using System.Collections;

public class trashCollector : MonoBehaviour {


	
	void OnCollisionEnter(Collision collision) {

		Destroy(collision.gameObject);
		
	}
}
