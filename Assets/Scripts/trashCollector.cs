using UnityEngine;
using System.Collections;

public class trashCollector : MonoBehaviour {


	
	void OnCollisionEnter(Collision collision) {


		SuitCaseMaker.collectCounter++;
		ScoreMgr.score -= 2;
		Destroy(collision.gameObject);

		
	}
}
