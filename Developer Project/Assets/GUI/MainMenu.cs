/// <summary>
/// Main menu.
/// Attached to Main Camera
/// </summary>
using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public Texture backgroundTexture;
	public Texture play;
	public Texture quit;

	//public GUIStyle texture;


	void OnGUI(){
		//Display Background Texture
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
	
		/*//Displays buttons
		if(GUI.Button (new Rect(Screen.width*guiPlacementLevelSelectX,Screen.height*guiPlacementLevelSelectY,Screen.width*.2f,Screen.height*.1f),"Level Select")){
			Application.LoadLevel ("LevelSelect");
		}

		if(GUI.Button (new Rect(Screen.width*guiPlacementOptionsX,Screen.height*guiPlacementOptionsY,Screen.width*.2f,Screen.height*.1f),"Options")){
			Application.LoadLevel ("Options");
		}*/
		//To use a texture
	 	//Displays buttons
		if(GUI.Button (new Rect(Screen.width*.3f,Screen.height*.9f,Screen.width*.4f,Screen.height*.2f),play,"")){
			Application.LoadLevel("Tutorial");
		}

		if(GUI.Button (new Rect(Screen.width*.7f,Screen.height*.9f,Screen.width*.8f,Screen.height*.4f),quit,"")){
			Application.Quit();
		}

	}
}