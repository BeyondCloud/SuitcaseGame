using UnityEngine;
using System.Collections;

public class LifeBar : MonoBehaviour {


	public static int life = 3;
	public GameObject gameover;
	bool isLoseLife;
	float oldLife = 0.5f;
	float newLife = 0.5f;
	float timer = 0;
	public Animation anim;

	void Start()
	{
		anim.Play("LifeBar");
	}
	void FixedUpdate()
	{
		timer += Time.deltaTime;
		if(isLoseLife)
		{
			renderer.material.SetFloat("_Cutoff", Mathf.Lerp(oldLife,newLife,timer*2)); 
			if(oldLife == newLife)
				isLoseLife = false;
		}
	}
    public void lossLife()
	{
		if(life > 0)
		   life--;
		isLoseLife = true;
		timer = 0;
		switch(life)
		{

		   case 2:
			    anim.Play("shake");
				newLife = 0.66f;
		   break;
		   case 1:
			    anim.Play("shake");
			    oldLife = 0.66f;
				newLife = 0.87f;
		   break;
	       case 0:
			    gameover.SetActive(true);
			    anim.Play("shake");
			    oldLife = 0.87f;
				newLife = 1.00f;
		   break;
		}

	}


}
