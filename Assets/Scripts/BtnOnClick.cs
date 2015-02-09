using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BtnOnClick : MonoBehaviour {


	public Animator loading;
	public Animator now;
	public Animator Op;
	private bool OpClose = true;
	private bool isPause;
public void Quit()
	{
		Application.Quit();
	}
public void StartGame()
	{
		loading.SetTrigger("loadingIn");
		now.SetTrigger("nowIn");

		StartCoroutine( WaitClipPlaneAnimToStart() );

	}
public void OpMenu()
	{
		if(OpClose)
		{
			Op.SetTrigger("openOPMenu");
			OpClose = false;
		}
		    
		else
		{
			Op.SetTrigger("closeOPMenu");
			OpClose = true;
		}
			

	}

public void PauseGame()
	{
	   if(!isPause)
		{
		 	Time.timeScale = 0;
			isPause = true;
		}
		else
		{
			Time.timeScale = 1.0f;
			isPause = false;
		}
			
	}
	IEnumerator WaitClipPlaneAnimToStart()
	{

		yield return new WaitForSeconds( 3 );
		Application.LoadLevel("Level0");
	}
}
