using UnityEngine;
using System.Collections;

public class BlueCollector : MonoBehaviour {

	public LifeBar lifebar;
	public int addScore = 5;
	
	public int minusScore = 10;

	void OnCollisionEnter(Collision collision) {

		if(collision.gameObject.name == "SuitCaseBlue(Clone)")
		{
			lifebar.ScaleMgr();
			
			ScoreMgr.score += addScore * LifeBar.scaleFactor;
		}
		else
		{
			lifebar.missPenalty();
			ScoreMgr.score -= minusScore;
		}
		SuitCaseMaker.collectCounter++;
		Destroy(collision.gameObject);
		
		
	}
}
