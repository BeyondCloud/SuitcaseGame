using UnityEngine;
using System.Collections;

public class SuitCaseMaker : MonoBehaviour {

	
	public GameObject box1;
	public GameObject box2;
	public GameObject box3;


	public float spawnTime = 1.0f;
	int randomNumber;
	void Start () {
		InvokeRepeating ("MakeBox", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void MakeBox()
	{
		randomNumber = Random.Range (0, 3);
	//	Instantiate (box, transform.position ,transform.rotation);

		switch(randomNumber)
		{
		case 0: Instantiate(box1 ,transform.position , transform.rotation); break;
			
		case 1: Instantiate(box2 ,transform.position ,transform.rotation); break;
			
		case 2: Instantiate(box3,transform.position  , transform.rotation); break;
			
		}



	}
}
