using UnityEngine;
using System.Collections;

public class LifeBar : MonoBehaviour {


	 public  float maxTime = 16.0f;
	 private float currentMaxTime ;
	 public  static int currentScaleLevel = 1;
	 public static int scaleFactor = 1;

	 float countDown = 0; 


	void Start()
	{
		currentMaxTime = maxTime;
		ScaleFactorUI.factor = scaleFactor;
	}
	void FixedUpdate () {

		renderer.material.SetFloat("_Cutoff", Mathf.InverseLerp(-currentMaxTime , currentMaxTime , countDown)); 
		if(countDown > 0 )
		   countDown -= Time.deltaTime;
		else if(currentScaleLevel != 0)
		{
		    
			currentScaleLevel--;
			scaleFactor =(int)Mathf.Pow(2,currentScaleLevel);
			ScaleFactorUI.factor = scaleFactor;
			currentMaxTime = maxTime/scaleFactor;
			countDown = currentMaxTime;
		

		}


	}

	public void ScaleMgr()
	{


		currentScaleLevel++;
		scaleFactor = (int)Mathf.Pow(2,currentScaleLevel);


		ScaleFactorUI.factor = scaleFactor;
		currentMaxTime = maxTime/scaleFactor;
		countDown = currentMaxTime;

	}
	public void missPenalty()
	{
		
		
		currentScaleLevel=0;
		scaleFactor = (int)Mathf.Pow(2,currentScaleLevel);
		
		
		ScaleFactorUI.factor = scaleFactor;
		currentMaxTime = maxTime/scaleFactor;
		countDown = currentMaxTime;
		
	}
}
