using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
	public GameObject bullet;	
	public float speed = 45f;
	public GameObject hero;
	
	void Update ()
	{
		// If the fire button is pressed...
		if(Input.GetButtonDown("Fire1"))
		{
			// If the player is facing right...
			/*if(hero.GetComponentInChildren<ArmRotation>().facingRight)
			{
				// ... instantiate the rocket facing right and set it's velocity to the right. 
				GameObject bulletInstance = Instantiate(bullet, transform.position, Quaternion.Euler(new Vector3(0,0,hero.GetComponentInChildren<ArmRotation>().angle))) as GameObject;
				//bulletInstance.transform.rotation = Quaternion.Euler (new Vector3(0f, 0f, hero.GetComponentInChildren<ArmRotation>().angle));
				//bulletInstance.velocity = new Vector2(speed, 0);
				//Vector3 force = new Vector3(Mathf.Cos (hero.GetComponentInChildren<ArmRotation>().angle)*speed, Mathf.Sin(hero.GetComponentInChildren<ArmRotation>().angle),0f);
				bulletInstance.GetComponent<Bullet>().angle = hero.GetComponentInChildren<ArmRotation>().angle;
			}
			else
			{
				// Otherwise instantiate the rocket facing left and set it's velocity to the left.
				GameObject bulletInstance = Instantiate(bullet, transform.position, Quaternion.Euler(new Vector3(0,0,180f))) as Rigidbody2D;
				//bulletInstance.transform.rotation = Quaternion.Euler (new Vector3(0f, 0f, hero.GetComponentInChildren<ArmRotation>().angle));
				//bulletInstance.velocity = new Vector2(-speed, 0);
				//Vector3 force = new Vector3(Mathf.Cos (hero.GetComponentInChildren<ArmRotation>().angle)*speed, Mathf.Sin(hero.GetComponentInChildren<ArmRotation>().angle),0f);
				//bulletInstance.rigidbody2D.velocity = force;
				bulletInstance.GetComponent<Bullet>().angle = hero.GetComponentInChildren<ArmRotation>().angle;
			} */
			float angle = hero.GetComponentInChildren<ArmRotation>().angle;
			float x = Mathf.Cos (Mathf.Deg2Rad*angle)*0.28f;
			float y = Mathf.Sin (Mathf.Deg2Rad*angle)*0.28f;
			GameObject bulletInstance = Instantiate(bullet, new Vector3(transform.position.x+x, transform.position.y+y, 0f), Quaternion.Euler(new Vector3(0,0,angle))) as GameObject;
			bulletInstance.GetComponent<Bullet>().angle = angle;
		}
	}
}
