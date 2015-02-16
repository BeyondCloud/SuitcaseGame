using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LevelMgr : MonoBehaviour {

	public Animator levelBoardanim;
	public static int currentLevel = 1;
	public static int currentPressDate = 1;
	public static bool updateLevelBoard = false;
	public AudioSource clickSound;
	Button btn;
	public GameObject postIt;
	void Start()
	{
		btn = gameObject.GetComponent<Button>();

		currentLevel = PlayerPrefs.GetInt("currentLevel");
		updateLevelBoard = true;
		if(int.Parse(btn.name) <= currentLevel)
			btn.interactable = true;
		else 
	     	btn.interactable = false;

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

		updateLevelBoard = false;
		clickSound.volume = OptionMenu.seVolume;
		clickSound.Play();
		if(currentPressDate != int.Parse(btn.name))
		{
			StartCoroutine(waitLevelboardUpdate());
			levelBoardanim.SetTrigger("levelBoardUp");
		}
		currentPressDate = int.Parse(btn.name);



		
	}
	IEnumerator waitLevelboardUpdate()
	{
		yield return new WaitForSeconds( 0.4f);
		updateLevelBoard = true;
	}

	
	
}
