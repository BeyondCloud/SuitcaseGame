using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreMgr : MonoBehaviour {

	
	public static int score;
	Text text;
	// Update is called once per frame
	void Awake()
	{
		text = GetComponent<Text> ();
		if(score == 0)
		  score = 0;
	}
	void Update()
	{
		text.text =  score + "$";
	}
}
