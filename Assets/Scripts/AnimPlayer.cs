using UnityEngine;
using System.Collections;

public class AnimPlayer : MonoBehaviour {


	// Update is called once per frame
	Animator anim;
	void Start()
	{
		anim = gameObject.GetComponent<Animator>();
	
	}



	public void callWave() 
	{
		anim.SetTrigger("waveDisplay");
	}
	public void callWave2() 
	{
		anim.SetTrigger("waveDisplay2");
	}
	public void callFinalWave() 
	{
		anim.SetTrigger("finalWave");
	}


}
