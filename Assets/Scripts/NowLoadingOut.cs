using UnityEngine;
using System.Collections;

public class NowLoadingOut : MonoBehaviour {

	public Animator loading;
	public Animator now;
	void Start () 
	{
		audio.volume = OptionMenu.seVolume;
		audio.Play();
		loading.SetTrigger("loadingOut");
		now.SetTrigger("nowOut");
	}
	

}
