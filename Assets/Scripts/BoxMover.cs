using UnityEngine;
using System.Collections;

public class BoxMover : MonoBehaviour {



	public Transform leftMarkPos;
	public Transform leftStart;
	public Transform rightMarkPos;
	public Transform rightStart;



	Animator anim;
	bool isRight = false;
	void Awake()
	{
		anim = GetComponent<Animator>();
	}
	void FixedUpdate ()
	{
	//	anim.enabled = false;
		if(transform.position.x < rightStart.position.x)
			anim.enabled = false;
		if(transform.position.x > rightMarkPos.position.x )
		{
			anim.enabled = true;
			anim.CrossFade("Right", 0f);
			transform.position = rightStart.position;

		//	anim.SetBool("isComeRight",true);
		//	isRight = true;

			
		}
		if(transform.position.x < leftMarkPos.position.x )
		{

			anim.enabled = true;
			anim.CrossFade("Left", 0f);
	//		anim.SetBool("isComeRight",false);
			transform.position = leftStart.position;
	//		anim.SetBool("goStart",true);
	//		anim.SetBool("isCome",true);

		//	isRight = false;

		}
		/*
	    if(anim.GetCurrentAnimatorStateInfo(0).IsName("end"))
		{	
			anim.SetBool("isComeRight",false);

			if(isRight )
			{
				transform.position = rightStart.position;
			}
			else
			{
				transform.position = leftStart.position;
				this.enabled = false;
			}

		}
*/
		
	}

}
