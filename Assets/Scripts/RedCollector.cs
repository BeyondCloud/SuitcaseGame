using UnityEngine;
using System.Collections;

public class RedCollector : MonoBehaviour {


	public int addScore = 5;
	
	public int minusScore = 10;

	void OnCollisionEnter(Collision collision) {
		

		if(collision.gameObject.name == "SuitCaseRed(Clone)")
			ScoreMgr.score += 5;
		else
			ScoreMgr.score -= minusScore;

		SuitCaseMaker.collectCounter++;
		Destroy(collision.gameObject);
		
		
	}
}
