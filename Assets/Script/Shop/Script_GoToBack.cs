using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_GoToBack : MonoBehaviour {

	public Button BackButton;
	// Use this for initialization
	void Start () {
		BackButton.onClick.AddListener (BackButtonPressed);
	}
	void BackButtonPressed()
	{
		Application.LoadLevel ("Start");
	}
	void Update(){
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel("Start");
		}
	}
}
