using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour {
	public float liftSpeed = 50;//speed (it will complete the motion in 1/speed seconds)

	public string  Key;

	//private var canPress : boolean = true;
	private float timer;


	


	void Update() 
	{ 
		timer += Time.deltaTime;

			
			if(Input.GetKeyDown(Key) )
			{   

		    	audio.volume  = OptionMenu.seVolume;
		    	audio.Play();

				print("w down");

			} 

		/*
			if(transform.position == target.transform.position)
			{
				moving = false; //reset flag 
				movingBack = true;
			}
			if(transform.position == startPosition)
			{
				movingBack = false;
				
			}
			if(moving) //check flag 
			{
				weight += Time.deltaTime * liftSpeed; //amount 
				transform.position = Vector3.Lerp(startPosition, target.transform.position, weight);
			} 
			if(movingBack) //check flag 
			{
				weight -= Time.deltaTime * liftSpeed; //amount 
				transform.position = Vector3.Lerp(startPosition, target.transform.position , weight);
			} 


         */






	}




	void push()
	{
		audio.volume  = OptionMenu.seVolume;
		audio.Play();
		print("mouse down");
		if(timer  > 0.3f)
		{
			timer = 0;

		}
		
	}

}
