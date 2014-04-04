using UnityEngine;
using System.Collections;

public class TimeScoreUpdater : MonoBehaviour {

	private GameObject cf;
	static float scoreTime = 0f;
	static float highScore = 0f;

	// Use this for initialization
	void Start () {
		//GameObject.FindWithTag("MainCamera").t
		//gameObject.GetComponent<GUIText>().transform
		cf = GameObject.Find("cartfront");
		highScore = PlayerPrefs.GetFloat ("highScore", 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (cf.GetComponent<PlayerCollider> ().isDead) {
			gameObject.GetComponent<GUIText>().text = "Final score time: " + scoreTime.ToString() +"\nHighscore: " + highScore.ToString();
		}
		else{
			scoreTime = Time.timeSinceLevelLoad;
			gameObject.GetComponent<GUIText>().text = "Time: " + scoreTime.ToString()  +"\nHighscore: " + highScore.ToString();
			if(highScore < scoreTime){
				highScore = scoreTime;
			}
		}
	}
	void OnDestroy(){
		PlayerPrefs.SetFloat("highScore",highScore);
	}
}
