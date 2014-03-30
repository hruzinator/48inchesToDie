using UnityEngine;
using System.Collections;

public class GenerateRails : MonoBehaviour {

	public GameObject[] rails;
	public static int length = 100;
	
	// Use this for initialization
	void Start () {
		float x = 0.0f;
		float y = -0.84f;
		for(int i = 0; i < rails.Length; i++) {
			rails[i] = Instantiate (rails[i], new Vector3(x, y, 0f), Quaternion.Euler (new Vector3(0f,0f,0f))) as GameObject;
			x -= 0.32f;
		}
	}
	
	// Update is called once per frame
	void Update () {
		foreach(GameObject rail in rails) {
			rail.transform.position = new Vector3((rail.transform.position.x-0.64f*Time.deltaTime)%((int)(rails.Length*0.32)-3), rail.transform.position.y, rail.transform.position.z);
		}
	}
}
