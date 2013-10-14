using UnityEngine;
using System.Collections;

public class SceneScript : MonoBehaviour {
	
	public string titleText = "Default scene";
	
	void OnGUI() {
	
	GUI.Box(new Rect(10,10,150,150), titleText);
		
	if (GUI.Button(new Rect(20,40,130,20), "GameplayScene")) {
		Application.LoadLevel("GameplayScene");
		}	
		
	if (GUI.Button(new Rect(20,60,130,20), "ResultsScene")) {
		Application.LoadLevel("ResultsScene");
		}
		
	if (GUI.Button(new Rect(20,80,130,20), "TitleScene")) {
		Application.LoadLevel("TitleScene");
		}
		
	if (GUI.Button(new Rect(20,100,130,20), "CreditsScene")) {
		Application.LoadLevel("CreditsScene");
		}
	
	if (GUI.Button(new Rect(20,120,130,20), "Quit")) {
		Application.Quit();
		}
	}
}