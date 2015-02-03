using UnityEngine;
using System.Collections;

public class BoxMover : MonoBehaviour {



	public Transform leftMarkPos;
	public Transform leftStart;
	Animator anim;

	void Awake()
	{
		anim = GetComponent<Animator>();
	}
	void Update ()
	{
	    if(transform.position.x < leftMarkPos.position.x )
		{
			anim.enabled = true;
			anim.SetBool("isCome",true);

		}
	    if(anim.GetCurrentAnimatorStateInfo(0).IsName("end"))
		{
			anim.enabled = false;
			transform.position = leftStart.position;
			this.enabled = false;
		}


	}

}
