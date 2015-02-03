using UnityEngine;
using System.Collections;

public class RotateObj : MonoBehaviour {



	public float rotateSpeed = 0;
	void FixedUpdate () 
	{
		transform.Rotate (new Vector3 (0, rotateSpeed, 0)*Time.deltaTime);	
	}
}
