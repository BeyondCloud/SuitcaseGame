using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScaleFactorUI : MonoBehaviour {


	Text text;
	public static int factor;
	// Update is called once per frame
	void Awake()
	{
		text = GetComponent<Text> ();
		
		factor = CashBar.scaleFactor;
	}
	void FixedUpdate()
	{
		text.text =  "X" + factor ;
	}
}
