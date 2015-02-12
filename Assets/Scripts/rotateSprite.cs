using UnityEngine;
using System.Collections;

public class rotateSprite : MonoBehaviour {


	public float rotateSpeed = 100.0f;
	public float rotateY = 0f;

	void Update () {
		transform.Rotate(new Vector3 (0,rotateY,rotateSpeed) * Time.deltaTime);	
	}
}
