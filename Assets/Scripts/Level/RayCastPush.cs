using UnityEngine;
using System.Collections;

public class RayCastPush : MonoBehaviour {



	
	void Update ()
		
	{



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
				//	     print (anim.name);
						anim.Play();
					}
					  
					
				}
			} 
			
		}
		
		
		
	}
	


}
