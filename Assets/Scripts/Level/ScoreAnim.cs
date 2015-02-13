using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreAnim : MonoBehaviour {

	public Text playerMoney;
	public Text score;
	private int initialPlayerMoney;
	private int initialScore;
	public Animator coin;
	public Animator threeBtn;

	public ParticleSystem coinParticle;
	bool startCount;
	void Awake()
	{

		initialPlayerMoney = PlayerInfo.playerMoney;

		initialScore = ScoreMgr.score;
		playerMoney.text =  PlayerInfo.playerMoney + "$";

		score.text = "+" + initialScore;
		StartCoroutine(wait2 ());
	}

	IEnumerator wait2()
	{
		yield return new WaitForSeconds( 2.0f );

		startCount = true;

		
	}
	void FixedUpdate()
	{
		if(startCount == true)
		{
			
			if(initialScore > 0)
			{
				
				playerMoney.text =  PlayerInfo.playerMoney + "$";
				score.text = "+" + initialScore;
				PlayerInfo.playerMoney += 50;
				initialScore -=  50;
			}
			else
			{
				print (initialScore);
				playerMoney.text = (initialPlayerMoney + ScoreMgr.score) + "$";
				score.text = "+" + 0;
				coin.SetTrigger("copper");
				threeBtn.SetTrigger("Up");
				coinParticle.Play ();
				startCount = false;
			}
		}

	}
	
	
}
