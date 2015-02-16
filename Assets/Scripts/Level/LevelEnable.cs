using UnityEngine;
using System.Collections;

public class LevelEnable : MonoBehaviour {


	void Start () 
	{

		print(LevelMgr.currentPressDate);
		switch(LevelMgr.currentPressDate)
		{
		   case 1:
			gameObject.GetComponent<Level1>().enabled = true;
		   break;
		   case 2:
			gameObject.GetComponent<Level2>().enabled = true;
		   break;
		}
	
	}
	

}
