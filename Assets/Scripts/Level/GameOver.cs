using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	Animation anim;
	public Animator threeBtn;
	public Animator fade;

  void Awake()
	{
		anim = gameObject.GetComponent<Animation>();
	}
  void Start()
	{
		anim.Play("gameover");
		StartCoroutine(wait());
		fade.SetTrigger("fade");

	}
	IEnumerator wait()
	{
		yield return new WaitForSeconds(0.5f);
		threeBtn.SetTrigger("Up");
	}
}
