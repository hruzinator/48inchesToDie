using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	private float maxSpeed = 90f;
	public float angle;

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 2);
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position = new Vector3(transform.position.x + 1.92f*Time.deltaTime, transform.position.y, transform.position.z);
		if(angle >= 0 && angle < 90) {
			transform.position = new Vector3(transform.position.x + 3.84f*(90-angle)*Mathf.PI/180.0f*Time.deltaTime, transform.position.y + 3.84f*angle*Mathf.PI/180.0f*Time.deltaTime, transform.position.z);
		} else if(angle >= 90 && angle <= 180) {
			transform.position = new Vector3(transform.position.x - 3.84f*(angle-90)*Mathf.PI/180.0f*Time.deltaTime, transform.position.y + 3.84f*(180-angle)*Mathf.PI/180.0f*Time.deltaTime, transform.position.z);
		} else if(angle > -90 && angle <= 0) {
			transform.position = new Vector3(transform.position.x - 3.84f*(-90-angle)*Mathf.PI/180.0f*Time.deltaTime, transform.position.y - 3.84f*(0-angle)*Mathf.PI/180.0f*Time.deltaTime, transform.position.z);
		} else if(angle <= -90 && angle >= -180) {
			transform.position = new Vector3(transform.position.x + 3.84f*(angle+90)*Mathf.PI/180.0f*Time.deltaTime, transform.position.y - 3.84f*(180+angle)*Mathf.PI/180.0f*Time.deltaTime, transform.position.z);
		}
	}
}
