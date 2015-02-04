using UnityEngine;
using System.Collections;

public class Pusher: MonoBehaviour {


	public Transform target;
	public float speed;
	Vector3 startPos;
	void Start()
	{
		startPos = transform.position;
	}
	void Update () 
	{
		float step = speed * Time.deltaTime;

		if(Input.GetKeyDown("w"))
		{
			print ("w down");
			float i = 0.0f; 
			float  rate = 0.1f/3.0f; 
			while (i < 1.0) 
			{ 
				i += Time.deltaTime * rate;
				transform.position =  Vector3.Lerp(startPos,target.position, i);

			}
		}

		
	}
}
