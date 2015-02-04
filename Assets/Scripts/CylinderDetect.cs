using UnityEngine;
using System.Collections;

public class CylinderDetect : MonoBehaviour 
{
	public Transform startPos; 
	void OnCollisionEnter(Collision collision) {

			collision.gameObject.transform.position = startPos.position;
		
	}
}