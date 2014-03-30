using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {

	private bool isPaused;
	private static int BUTTON_WIDTH = 75;
	private static int BUTTON_HEIGHT = 25;
	private static int BUTTON_SPACE = 15+BUTTON_HEIGHT;
	
	// Use this for initialization
	void Start () {
		isPaused = false;
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			isPaused = !isPaused;
			if(isPaused) {
				Time.timeScale = 0;
			} else {
				Time.timeScale = 1;
			}
		}
	}
	
	void OnGUI() {
		if(isPaused) {
			if(GUI.Button (new Rect((Screen.width-BUTTON_WIDTH)/2, (Screen.height-BUTTON_HEIGHT)/2, BUTTON_WIDTH, BUTTON_HEIGHT), "Resume")) {
				isPaused = !isPaused;
				Time.timeScale = 1;
			}
			if(GUI.Button (new Rect((Screen.width-BUTTON_WIDTH)/2, (Screen.height-BUTTON_HEIGHT)/2+BUTTON_SPACE, BUTTON_WIDTH, BUTTON_HEIGHT), "Quit")) {
				//Application.LoadLevel("MainMenu");
				Application.Quit ();
			}
		}
	}
}