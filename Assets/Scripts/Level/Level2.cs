using UnityEngine;
using System.Collections;

public class Level2 : MonoBehaviour {

	public Animator loading;
	public Animator now;
	public AnimPlayer animPlayer;
	public GameObject judgeList;
	public GameObject box1;
	public GameObject box2;
	public GameObject box3;
	public float spawnTime = 1.0f;
	public float waitBeforeSpawn = 1.5f;
	public int silver;
	public int gold;
	
	
	private int counter = 0;
	private  int boxNumInWave = 5;
	

	private int wave = 0;
	int randomNumber;
	bool waveStart;
	
	void Start()
	{
		
	
		loading.SetTrigger("loadingOut");
		now.SetTrigger("nowOut");
		
	}
	void FixedUpdate()
	{
		
		
		
		
		if(counter >= boxNumInWave)
		{
			
			CancelInvoke();
			
			
		}
		
		if(SuitcaseCounter.collectCounter == boxNumInWave)
		{
			
			counter = 0;
			SuitcaseCounter.collectCounter = 0;
			waveStart = false;
			
			wave++;
		}
		
		
		if(!waveStart)
		{
			if(LifeBar.life != 0)
				waveMgr(wave);
			
		}
		

		
		
		
	}
	void waveMgr(int wave)
	{
		switch(wave)
		{
		case 0:
			StartCoroutine( HandleIt() );
			
			boxNumInWave = 1;
			waveStart = true;
			InvokeRepeating ("MakeBox", waitBeforeSpawn +2.0f, spawnTime);
			
			break;
		case 1:
			animPlayer.callWave2();
			boxNumInWave = 1;
			waveStart = true;
			InvokeRepeating ("MakeBox",  waitBeforeSpawn, spawnTime);
			break;
		case 2:
			animPlayer.callFinalWave();
			boxNumInWave = 1;
			waveStart = true;
			InvokeRepeating ("MakeBox",  waitBeforeSpawn, spawnTime);
			break;
		case 3:
		{
			LevelMgr.currentLevel = 3;
			PlayerPrefs.SetInt("currentLevel",LevelMgr.currentLevel);
			StoreHighscore(ScoreMgr.score);

			CoinJudge.silverScore = silver;
			CoinJudge.goldScore = gold;
			judgeList.SetActive(true);
		}
			
			break;
			
		}
	}
	
	// Update is called once per frame
	void MakeBox()
	{
		audio.volume = OptionMenu.seVolume;
		audio.Play();
		counter++;
		
		randomNumber = Random.Range (0, 3);
		
		switch(randomNumber)
		{
		case 0: Instantiate(box1 ,transform.position , transform.rotation); break;
			
		case 1: Instantiate(box2 ,transform.position ,transform.rotation); break;
			
		case 2: Instantiate(box3,transform.position  , transform.rotation); break;
			
		}
		
		
		
	}
	void StoreHighscore(int newHighscore)
	{
		int oldHighscore = PlayerPrefs.GetInt("highscore2", 0);    
		if(newHighscore > oldHighscore)
			PlayerPrefs.SetInt("highScore2", newHighscore);
		
	}
	IEnumerator HandleIt()
	{
		
		yield return new WaitForSeconds( 2.0f );
		animPlayer.callWave();
		
	}
}
