using UnityEngine;
using System.Collections;

public class trashCollector : MonoBehaviour {


	public LifeBar lifeBar;
	void OnCollisionEnter(Collision collision) {


		audio.volume = OptionMenu.seVolume;
		audio.Play ();
		if(collision.gameObject.tag != "TNT")
		{
			SuitcaseCounter.collectCounter++;
			ScoreMgr.score -= 2;
			lifeBar.lossLife();
		}

		Destroy(collision.gameObject);

		
	}
}
