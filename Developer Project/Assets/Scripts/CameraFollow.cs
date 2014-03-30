using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	private Transform camera;
	
	// Use this for initialization
	void Start () {
		camera = GameObject.Find ("Main Camera").transform;
	}
	
	// Update is called once per frame
	void Update () {
		camera.position = new Vector3(transform.position.x, 0f, -10f);
	}
}
