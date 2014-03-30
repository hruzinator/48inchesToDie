using UnityEngine;
using System.Collections;

public class HeroAnimator : MonoBehaviour {

	public Sprite[] sprites;
	public Transform gun;
	
	private SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Start () {
		spriteRenderer = renderer as SpriteRenderer;
	}
	
	// Update is called once per frame
	void Update () {
		float angle = gun.GetComponent<ArmRotation>().angle;
		
		if(angle < -45 && angle > -135) {
			spriteRenderer.sprite = sprites[1];
		} else if(angle > 45 && angle < 135) {
			spriteRenderer.sprite = sprites[2];
		} else {
			spriteRenderer.sprite = sprites[0];
		}
	}
}
