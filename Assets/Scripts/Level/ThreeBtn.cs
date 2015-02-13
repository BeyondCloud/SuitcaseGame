using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ThreeBtn : MonoBehaviour {



	public Animator loading;
	public Animator now;
	public ParticleSystem particleOff;
	public void goHome()
	{
		particleOff.enableEmission = false;
		playClickSound();
		nowLoadingIn();
		StartCoroutine("mainMenuWait");
	}
	public void rePlay()
	{
		ScoreMgr.score = 0;
		Application.LoadLevel(Application.loadedLevel);
	}
	public void nextLevel()
	{
		particleOff.enableEmission = false;
		playClickSound();
		nowLoadingIn();
		StartCoroutine("nextLevelWait");
	}


	IEnumerator mainMenuWait()
	{
		
		yield return new WaitForSeconds( 1.5f );
		ScoreMgr.score = 0;
		Application.LoadLevel("MainMenu");
	}
	IEnumerator nextLevelWait()
	{
		
		yield return new WaitForSeconds( 1.5f );
		ScoreMgr.score = 0;
		Application.LoadLevel("calendar");
	}
	void playClickSound()
	{
		audio.volume = OptionMenu.seVolume;
		audio.Play();
	}
	void nowLoadingIn()
	{
	loading.SetTrigger("loadingIn");
	now.SetTrigger("nowIn");
	}

}
