using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_SingleStartButton : MonoBehaviour {

	public Button StartButton;
	public Image SelectedCharacter;
	// Use this for initialization
	void Start () {
		StartButton.onClick.AddListener (StartClicked);
	}
	void StartClicked()
	{
		if (SelectedCharacter.sprite != null) {
			Script_Variables.CharacterName=Script_SingleSelect.NowNum;
			for(int i=0;i<4;i++)
			{
				if(GameObject.Find("ItemButton"+(i+1)).GetComponent<Toggle>().isOn)
				{
					Script_Variables.item[i]=true;
				}
				else
				{
					Script_Variables.item[i]=false;
				}
			}
			if(!Script_Text.CharacterEnabled[Script_Variables.CharacterName-1])
			{
				return;
			}
			Application.LoadLevel("InGame");
		}
	}
	
}
