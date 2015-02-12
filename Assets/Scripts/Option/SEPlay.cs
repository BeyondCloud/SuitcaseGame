using UnityEngine;
using System.Collections;

public class SEPlay : MonoBehaviour {

	// Use this for initialization
	void Start() {
		audio.volume = OptionMenu.seVolume;
		audio.Play();
	}



}
