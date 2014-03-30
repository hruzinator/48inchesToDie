using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	
	public float moveSpeed = .5f;
	public float growSpeed = .5f;
	private Vector3 finalScale;
	
	private bool intro = true;
	
	// Use this for initialization
	void Start () {
		finalScale = transform.localScale;
		transform.localScale = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void FixedUpdate() {
		if (intro) {
			float step = growSpeed * Time.deltaTime;
			transform.localScale += new Vector3(step, step, step);
			if(transform.localScale.x >= finalScale.x){
				transform.localScale = finalScale;
				intro = false;
			}
		} 
		else {
			float step = moveSpeed * Time.deltaTime;
			transform.position = Vector3.MoveTowards ((Vector3)transform.position, (Vector3)Camera.main.transform.position, step);
		}
	}

	void OnTriggerEnter(Collider other) {
			gameObject.GetComponent<AudioSource>().Play();
			Destroy(other.gameObject);
	}
}