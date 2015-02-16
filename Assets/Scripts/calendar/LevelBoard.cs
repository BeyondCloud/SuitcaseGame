using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelBoard : MonoBehaviour {
	public Text highScore;
	public Text levelSelect;
	public Animator levelBoard;
	string highScoreToDisplay;
	void FixedUpdate()
	{
		if(LevelMgr.updateLevelBoard == true)
		{

			highScoreToDisplay = "highScore" + LevelMgr.currentPressDate;
			highScore.text =   PlayerPrefs.GetInt(highScoreToDisplay)+ "$";
			levelSelect.text = "Level" + LevelMgr.currentPressDate;
		}

	}
	
	
	
}
