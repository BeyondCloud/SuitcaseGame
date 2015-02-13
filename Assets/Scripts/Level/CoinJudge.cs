using UnityEngine;
using System.Collections;

public class CoinJudge : MonoBehaviour {



	public Sprite silver;
	public Sprite gold;
	public static int silverScore;
	public static int goldScore;

	void Start()
	{

	   if(ScoreMgr.score >= goldScore)
			GetComponent<UnityEngine.UI.Image>().sprite = gold;
	   else if(ScoreMgr.score >= silverScore)
	    	GetComponent<UnityEngine.UI.Image>().sprite = silver;
	    	
	}

}
