using UnityEngine;
using System.Collections;

public class Level1: MonoBehaviour {
	
	public Animator loading;
	public Animator now;
	public AnimPlayer animPlayer;
	public GameObject box1;
	public GameObject box2;
	public GameObject box3;
	private  int boxNumInWave = 5;
	public float spawnTime = 1.0f;
	public float waitBeforeSpawn = 1.5f;
	
	private int counter = 0;

	Animator anim;
	
	private int wave = 0;
	int randomNumber;
	bool waveStart;
	
	void Start()
	{
		
		anim = gameObject.GetComponent<Animator>();
		
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
			//StartCoroutine( HandleIt() );
			
			//anim.CrossFade("WaveFlyIn", 0F);;
			waveMgr(wave);
			
		}
		
		
		
		
	}
	void waveMgr(int wave)
	{
		switch(wave)
		{
		case 0:
			StartCoroutine( HandleIt() );
			
			boxNumInWave = 5;
			waveStart = true;
			InvokeRepeating ("MakeBox", waitBeforeSpawn +2.0f, spawnTime);
			
			break;
		case 1:
			animPlayer.callWave2();
			boxNumInWave = 6;
			waveStart = true;
			InvokeRepeating ("MakeBox",  waitBeforeSpawn, spawnTime);
			break;
		case 2:
			animPlayer.callFinalWave();
			boxNumInWave = 7;
			waveStart = true;
			InvokeRepeating ("MakeBox",  waitBeforeSpawn, spawnTime);
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
	IEnumerator HandleIt()
	{
		
		yield return new WaitForSeconds( 2.0f );
		animPlayer.callWave();
		
	}
}
