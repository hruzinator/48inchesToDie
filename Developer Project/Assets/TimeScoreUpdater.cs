using UnityEngine;
using System.Collections;

public class TimeScoreUpdater : MonoBehaviour {

	private GameObject cf;
	private float scoreTime;

	// Use this for initialization
	void Start () {
		//GameObject.FindWithTag("MainCamera").t
		//gameObject.GetComponent<GUIText>().transform
		cf = GameObject.Find("cartfront");
	}
	
	// Update is called once per frame
	void Update () {
		if (cf.GetComponent<PlayerCollider> ().isDead) {
			gameObject.GetComponent<GUIText>().text = "Final score time: " + scoreTime.ToString();
		}
		else{
			scoreTime = Time.realtimeSinceStartup;
			gameObject.GetComponent<GUIText>().text = "Time: " + scoreTime.ToString();
		}
	}
}
