using UnityEngine;
using System.Collections;

public class BlueCollector : MonoBehaviour {

	public CashBar cashBar;
	public LifeBar lifeBar;
	public int addScore = 5;
	public ParticleSystem cashParticle;
	public int minusScore = 10;
	public AudioClip wrong;

	void OnCollisionEnter(Collision collision) {

		if(collision.gameObject.name == "SuitCaseBlue(Clone)")
		{
			cashParticle.Play();
			cashBar.ScaleMgr();
			audio.volume = OptionMenu.seVolume;
			audio.Play();
			ScoreMgr.score += addScore * CashBar.scaleFactor;
		}
		else
		{
			lifeBar.lossLife();
			audio.volume = OptionMenu.seVolume;
			audio.PlayOneShot(wrong);
			if(OptionMenu.isVibrant != 0 )
			{
				Handheld.Vibrate();
			}
			cashBar.missPenalty();
			ScoreMgr.score -= minusScore;
		}
		SuitcaseCounter.collectCounter++;
		Destroy(collision.gameObject);
		
		
	}
}
