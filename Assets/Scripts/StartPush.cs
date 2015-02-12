using UnityEngine;
using System.Collections;

public class StartPush : MonoBehaviour {

	public Animator loading;
	public Animator now;
	
   public void gameStart()
	{
		audio.volume = OptionMenu.seVolume;
		audio.Play();
		loading.SetTrigger("loadingIn");
		now.SetTrigger("nowIn");

		StartCoroutine(WaitAnim());

	}
	IEnumerator WaitAnim()
	{
		
		yield return new WaitForSeconds( 1.5f);
		switch(LevelMgr.currentPressDate)
		{
		case 1:
			Application.LoadLevel("Level1");
			break;
		case 2:
			Application.LoadLevel("Level1");
			break;
		case 3:
			Application.LoadLevel("Level3");
			break;
		}
	}
}
