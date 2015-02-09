using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class OptionMenu : MonoBehaviour {

	public   Slider seSlider;
	public static float seVolume = 0.8f;
	public  Slider bgmSlider;
	public static float bgmVolume = 0.8f;
	public Scrollbar vibrantScrollBar;
	public static float isVibrant = 1.0f;
	public void onSEChange()
	{
		seVolume = seSlider.value; 
	}
	public void onBGMChange()
	{
		bgmVolume = bgmSlider.value; 
	}
	public void onVibrastion()
	{
		isVibrant = vibrantScrollBar.value;  
	}
	void Update()
	{
		this.audio.volume = bgmVolume;
	}
}
