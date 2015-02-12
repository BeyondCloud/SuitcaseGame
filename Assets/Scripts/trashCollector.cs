using UnityEngine;
using System.Collections;

public class trashCollector : MonoBehaviour {


	
	void OnCollisionEnter(Collision collision) {

		audio.volume = OptionMenu.seVolume;
		audio.Play ();
		SuitcaseCounter.collectCounter++;
		ScoreMgr.score -= 2;
		Destroy(collision.gameObject);

		
	}
}
