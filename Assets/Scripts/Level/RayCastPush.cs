using UnityEngine;
using System.Collections;

public class RayCastPush : MonoBehaviour {



	
	void Update ()
		
	{


		/*DONNOT DELELT THIS!!!!!!!!!!!!!!!!!!!!!!!!!!!

		  //this is code for mobile
		if(Input.touchCount > 0)
		{
			for(int i= 0; i<Input.touchCount; i++)
			{
				if(Input.touches[i].phase == TouchPhase.Began)
				{

					print("click");
					Ray ray = Camera.main.ScreenPointToRay(Input.touches[i].position);
					RaycastHit hit;
					if (Physics.Raycast(ray, out hit, 35.5f))
					{
						Debug.DrawLine(ray.origin, hit.point);
						//print(hit.collider.name);
				//		push(hit.collider.name);
						Animation anim = hit.collider.gameObject.GetComponent<Animation>();
						anim.Play();
					}
					  
					
				}
			} 
			
		}
           //this is code for mobile

         */



		//this is code for debug

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit, 35.5f))
		{
			Debug.DrawLine(ray.origin, hit.point);
			//print(hit.collider.name//this is code for mobile);
			//		push(hit.collider.name);

			if(hit.collider.gameObject.tag == "pusher")
			{
				Animation anim = hit.collider.gameObject.GetComponent<Animation>();
				anim.Play();
			}

		}


		//this is code for debug



		
		

	}


}
