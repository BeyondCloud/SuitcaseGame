using UnityEngine;
using System.Collections;

public class RedCollector : MonoBehaviour {

	public LifeBar lifebar;
	public int addScore = 5;
	
	public int minusScore = 10;

	void OnCollisionEnter(Collision collision) {
		

		if(collision.gameObject.name == "SuitCaseRed(Clone)")
		{
			lifebar.ScaleMgr();
			
			ScoreMgr.score += addScore * LifeBar.scaleFactor;
		}
		else
		{
			if(OptionMenu.isVibrant != 0 )
			{
				Handheld.Vibrate();
			}
			lifebar.missPenalty();
			ScoreMgr.score -= minusScore;
		}
		SuitCaseMaker.collectCounter++;
		Destroy(collision.gameObject);
		
		
	}
}
