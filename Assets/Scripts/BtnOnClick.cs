using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BtnOnClick : MonoBehaviour {


	public Animator clipPlane;
	private bool isPause;
public void Quit()
	{
		Application.Quit();
	}
public void StartGame()
	{
		clipPlane.SetTrigger("clipPlaneIn");
		StartCoroutine( WaitClipPlaneAnimToStart() );

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
