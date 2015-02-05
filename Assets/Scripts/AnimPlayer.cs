using UnityEngine;
using System.Collections;

public class AnimPlayer : MonoBehaviour {


	// Update is called once per frame
	Animator anim;
	void Start()
	{
		anim = gameObject.GetComponent<Animator>();
	
	}



	public void test() 
	{
		anim.SetTrigger("waveDisplay");
	
	}
}
