using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Camera cam;
	
	// Use this for initialization
	void Start () {
		cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		cam.transform.position = new Vector3(transform.position.x, 0f, -10f);
	}
}
