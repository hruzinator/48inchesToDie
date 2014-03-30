using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {
	
	public int hp;
	public bool isDead;
	public GameObject[] carts;
	private int index;
	public AudioSource[] deathSounds;
	
	void Awake() {
		isDead = false;
		if(hp <= 0) {
			hp = 3;
		}
		index = carts.Length-1;
	}
	
	void OnTriggerEnter2D(Collider2D collision){
		if(collision.tag == "Enemy") {
			hp -= 1;
			if(index >= 0) {
				deathSounds[0].Play ();
				deathSounds[index+1].Play ();
				Destroy (carts[index]);
				index -= 1;
			}
		}
	}
	
	void Update(){
		if(hp <= 0) {
			isDead = true;
			SpecialEffectsHelper.Instance.Explosion(transform.position);
			Destroy(GameObject.Find ("ourhero").gameObject);
			print ("Game Over");
		}
	}
}
