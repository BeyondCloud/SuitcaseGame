using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LevelMgr : MonoBehaviour {

	public Animator levelBoard;
	public static int currentLevel = 1;
	public static int currentPressDate;
	public AudioSource clickSound;
	int maxLevel = 3;
	Button btn;
	public GameObject postIt;
	void Start()
	{
		btn = gameObject.GetComponent<Button>();
		if(btn.name != "1")
		 btn.interactable = false;
		else 
	     btn.interactable = true;

		postIt.SetActive(false);
		currentPressDate = currentLevel;

	}
	void Update()
	{

		if(int.Parse(btn.name) == currentPressDate)
		{
			postIt.SetActive(true);

		}
			
		else
		{
			postIt.SetActive(false);


		}
			

		if(int.Parse(btn.name) == (currentLevel))
			btn.interactable = true;
	}
	public void Onclick()
	{
		clickSound.volume = OptionMenu.seVolume;

		clickSound.Play();
		if(currentPressDate != int.Parse(btn.name))
		{
			levelBoard.SetTrigger("levelBoardUp");
		}

		currentPressDate = int.Parse(btn.name);
		if(currentLevel != maxLevel)
		{
			levelBoard.SetTrigger("levelBoardDown");

		}

		
	}
	
	
	
}
