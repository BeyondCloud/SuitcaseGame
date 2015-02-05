using UnityEngine;
using System.Collections;

public class BlueCollector : MonoBehaviour {


	public int addScore = 5;
	
	public int minusScore = 10;

	void OnCollisionEnter(Collision collision) {

		if(collision.gameObject.name == "SuitCaseBlue(Clone)")
			ScoreMgr.score += 5;
		else
			ScoreMgr.score -= minusScore;

		SuitCaseMaker.collectCounter++;
		Destroy(collision.gameObject);
		
		
	}
}
