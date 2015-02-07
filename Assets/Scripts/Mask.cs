using UnityEngine;
using System.Collections;

public class Mask : MonoBehaviour {


	public Transform depthPlane;
	Camera cam;
	
	void Start () {
		cam = GetComponent<Camera>();
	}
	
	void Update () {
		cam.pixelRect = new Rect(0,0 , 854, 480);
		depthPlane.localScale = new Vector3(cam.orthographicSize, cam.orthographicSize, cam.orthographicSize);
	}
}
