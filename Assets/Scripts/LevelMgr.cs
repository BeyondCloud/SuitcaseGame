using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LevelMgr : MonoBehaviour {


	public static int currentLevel = 1;
	static int currentPressDate;
	int maxLevel = 3;
	Button btn;
	Text text;
	public Image post;
	void Start()
	{
		btn = gameObject.GetComponent<Button>();
		text = this.GetComponentInChildren<Text>();
		if(btn.name != "1")
		 btn.interactable = false;
		else 
	     btn.interactable = true;

		text.enabled = false;
		post.enabled = false;
		currentPressDate = currentLevel;

	}
	void Update()
	{

		if(int.Parse(btn.name) == currentPressDate)
		{
			text.enabled = true;
			post.enabled = true;
		}
			
		else
		{
			text.enabled = false;
			post.enabled = false;

		}
			

		if(int.Parse(btn.name) == (currentLevel))
			btn.interactable = true;
	}
	public void Onclick()
	{

		  currentPressDate = int.Parse(btn.name);
		if(currentLevel != maxLevel)
		  currentLevel++;


	}
   


}
