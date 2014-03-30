using UnityEngine;
using System.Collections;

public class MoveCart : MonoBehaviour {

	private float maxSpeed = 15f;
	
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = new Vector3(maxSpeed, 0f, 0f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rigidbody2D.velocity = new Vector3(maxSpeed, 0f, 0f);
	}
}
