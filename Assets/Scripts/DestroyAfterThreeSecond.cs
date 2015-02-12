using UnityEngine;
using System.Collections;

public class DestroyAfterThreeSecond : MonoBehaviour {

	public GameObject objToDestroy;
	void Start ()
	{
		StartCoroutine(destroy());
	
	}
	
	IEnumerator destroy()
	{
		yield return new WaitForSeconds( 3.0f );
		Destroy(objToDestroy);
	}
}
