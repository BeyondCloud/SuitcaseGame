using UnityEngine;
using System.Collections;

public class AutoSpawn : MonoBehaviour {

	public GameObject box1;
	public GameObject box2;
	public GameObject box3;
	int randomNumber;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("MakeBox", 5.0f, 5.0f);
	}
	
	void MakeBox()
	{
		

		randomNumber = Random.Range (0, 3);
		
		switch(randomNumber)
		{
		case 0: Instantiate(box1 ,transform.position , transform.rotation); break;
			
		case 1: Instantiate(box2 ,transform.position ,transform.rotation); break;
			
		case 2: Instantiate(box3,transform.position  , transform.rotation); break;
			
		}
		
		
		
	}
}
