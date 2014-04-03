﻿using UnityEngine;
using System.Collections;

public class MoveCart : MonoBehaviour {

	public float maxSpeed = 1f;
	public float accelerateSpeed = .25f;
	
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = new Vector3(maxSpeed, 0f, 0f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rigidbody2D.velocity = new Vector2(maxSpeed, 0f);
		/*if (rigidbody2D.velocity.x < maxSpeed) {
			Debug.Log("trying to add force");
			rigidbody2D.AddForce(new Vector2(.25f, 0f));
		} else {
			rigidbody2D.velocity = new Vector2(maxSpeed, 0f);
		}*/
		Debug.Log ("Fixed update with x velocity: " + rigidbody2D.velocity.x);
		//rigidbody2D.velocity = new Vector3(maxSpeed, 0f, 0f);
	}
}
