using UnityEngine;
using System.Collections;

public class ArmRotation : MonoBehaviour {

	public Transform hero;
	public bool facingRight;
	public float angle;
	
	// Use this for initialization
	void Start () {
		facingRight = true;
		angle = 0;
		hero.transform.position = new Vector3(hero.transform.position.x-0.16f, hero.transform.position.y, hero.transform.position.z);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 10; //The distance from the camera to the player object
		Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
		lookPos = lookPos - transform.position;
		angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
		
		if(facingRight) {
			if(angle > 90 || angle < -90) {
				hero.localScale = new Vector3(hero.localScale.x*-1, hero.localScale.y, hero.localScale.z);
				hero.transform.position = new Vector3(hero.transform.position.x+0.18f, hero.transform.position.y, hero.transform.position.z);
				facingRight = false;
			} else {
				transform.rotation = Quaternion.Euler (new Vector3(0f, 0f, angle));
			}
		} else {
			if(angle < 90 && angle > -90) {
				hero.localScale = new Vector3(hero.localScale.x*-1, hero.localScale.y, hero.localScale.z);
				hero.transform.position = new Vector3(hero.transform.position.x-0.18f, hero.transform.position.y, hero.transform.position.z);
				facingRight = true;
			} else if(angle > 90){
				transform.rotation = Quaternion.Euler (new Vector3(0f, 0f, 180-angle));
			} else {
				transform.rotation = Quaternion.Euler (new Vector3(0f, 0f, -(180+angle)));
			}
		}
	}
}
