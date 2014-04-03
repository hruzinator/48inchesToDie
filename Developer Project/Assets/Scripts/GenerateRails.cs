using UnityEngine;
using System.Collections;

public class GenerateRails : MonoBehaviour {

	/* 
	 * Input: trackWidth
	 * 
	 * store backmost rail
	 * if backmost
	 * 
	 */

	public GameObject[] rails;
	public static int length = 100;
	public float backLength = 20;
	public GameObject referenceObject;

	private float segmentWidth;
	private int backRailIndex;
	private int frontRailIndex;

	// Use this for initialization
	void Start () {
		float x = 0.0f;
		float y = -0.84f;
		for(int i = 0; i < rails.Length; i++) {
			rails[i] = Instantiate (rails[i], new Vector3(x, y, 0f), Quaternion.Euler (new Vector3(0f,0f,0f))) as GameObject;
			x -= 0.32f;
		}
		backRailIndex = 0;
		frontRailIndex = length - 1;
		segmentWidth = rails [0].gameObject.renderer.bounds.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		float playerXPos = referenceObject.transform.position.x;
		float backRailXPos = rails [backRailIndex].transform.position.x;
		while (backRailXPos > playerXPos - backLength) {
			moveNextRail();
			playerXPos = referenceObject.transform.position.x;
			backRailXPos = rails [backRailIndex].transform.position.x;
		}
	}

	private void moveNextRail(){
		Debug.Log ("Generating next rail");
		Vector3 offset = new Vector3 (segmentWidth, 0, 0);
		rails [backRailIndex].transform.position = rails [frontRailIndex].transform.position + offset;
		frontRailIndex = backRailIndex;
		backRailIndex = (backRailIndex+1)%length;
	}
}
