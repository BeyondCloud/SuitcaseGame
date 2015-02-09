using UnityEngine;
using System.Collections;

public class BGMplay : MonoBehaviour {

	void Start () {
		audio.volume = OptionMenu.bgmVolume;
		audio.Play();
	}
}
