using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public GameObject cartfront;
	private static int BUTTON_WIDTH = 75;
	private static int BUTTON_HEIGHT = 25;
	private static int BUTTON_SPACE = 15+BUTTON_HEIGHT;
	public Texture gameOver;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI() {
		if(cartfront.GetComponent<PlayerCollider>().isDead) {
			GUI.DrawTexture(new Rect((Screen.width-288)/2, (Screen.height-192)/2, 288, 192), gameOver);
			if(GUI.Button (new Rect((Screen.width-BUTTON_WIDTH)/2, (Screen.height-BUTTON_HEIGHT)/2+175, BUTTON_WIDTH, BUTTON_HEIGHT), "Play Again")) {
				Application.LoadLevel ("Tutorial");
			}
			if(GUI.Button (new Rect((Screen.width-BUTTON_WIDTH)/2, (Screen.height-BUTTON_HEIGHT)/2+175+BUTTON_SPACE, BUTTON_WIDTH, BUTTON_HEIGHT), "Quit")) {
				Application.Quit ();
			}
		}
	}
}
