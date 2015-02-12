using UnityEngine;
using System.Collections;

public class YellowCollector : MonoBehaviour {


	public LifeBar lifebar;
	public int addScore = 5;
	public int minusScore = 10;
	public ParticleSystem cashParticle;
	public AudioClip wrong;


	void OnCollisionEnter(Collision collision) {

		if(collision.gameObject.name == "SuitCaseYellow(Clone)")
		{
			cashParticle.Play();
			lifebar.ScaleMgr();
			audio.volume = OptionMenu.seVolume;
			audio.Play();
			ScoreMgr.score += addScore * LifeBar.scaleFactor;
		}
			
		else
		{
			audio.volume = OptionMenu.seVolume;
			audio.PlayOneShot(wrong);
			if(OptionMenu.isVibrant != 0 )
			{
				Handheld.Vibrate();
			}
			lifebar.missPenalty();
			ScoreMgr.score -= minusScore;
		}
			

		SuitcaseCounter.collectCounter++;
		Destroy(collision.gameObject);
		
		
	}
}
