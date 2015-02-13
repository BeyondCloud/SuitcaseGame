﻿using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour {
	public GameObject target; //destination
	public float liftSpeed = 50;//speed (it will complete the motion in 1/speed seconds)

	public string  Key;
	private bool moving = false; //flag 
	private bool movingBack  = false; //back flag 
	//private var canPress : boolean = true;
	private float timer;
	private  float weight = 0; //amount moved 
	private Vector3 startPosition ; //Where we start;
	void Update() 
	{ 
		timer += Time.deltaTime;

			
			if(Input.GetKeyDown(Key) )
			{   

		    	audio.volume  = OptionMenu.seVolume;
		    	audio.Play();

				print("w down");
				if(timer  > 0.3f)
				{
					
					timer = 0;
					startPosition = transform.position; //Set the start 
					moving = true; //set flag 
				}
			} 
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

	}
	void OnMouseDown()
	{
		audio.volume  = OptionMenu.seVolume;
		audio.Play();
		print("mouse down");
		if(timer  > 0.3f)
		{
			timer = 0;
			startPosition = transform.position; //Set the start 
			moving = true; //set flag 
		}
		
	}
}
