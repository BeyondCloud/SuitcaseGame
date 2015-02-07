using UnityEngine;
using System.Collections;

public class ClickPlayer : MonoBehaviour {



	Animator anim;
	void Start()
	{
		anim = gameObject.GetComponent<Animator>();
	}
	
	void OnMouseDown()
	{
		anim.SetTrigger("click");
	}


}
