using UnityEngine;
using System.Collections;

public class EnemyCollider : MonoBehaviour {
	
	public int hp;
	public bool isDead;
	
	void Awake() {
		isDead = false;
		if(hp <= 0) {
			hp = 1;
		}
	}
	
	void OnTriggerEnter2D(Collider2D collision){
		if(collision.tag == "Bullet") {
			hp -= 1;
		} else if(collision.tag == "Hero") {
			Destroy (gameObject);
		}
	}
	
	void Update(){
		if(hp <= 0) {
			isDead = true;
			SpecialEffectsHelper.Instance.Explosion(transform.position);
			Destroy(gameObject);
		}
	}
}
