using UnityEngine;
using System.Collections;

public class YellowCollector : MonoBehaviour {



	public int addScore = 5;

	public int minusScore = 10;


	void OnCollisionEnter(Collision collision) {

		if(collision.gameObject.name == "SuitCaseYellow(Clone)")
			ScoreMgr.score += addScore;
		else
			ScoreMgr.score -= minusScore;

		SuitCaseMaker.collectCounter++;
		Destroy(collision.gameObject);
		
		
	}
}
