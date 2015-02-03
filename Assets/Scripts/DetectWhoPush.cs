using UnityEngine;
using System.Collections;


public class DetectWhoPush: MonoBehaviour {
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == "punch")
			collision.gameObject.tag = "afP";

	}

}