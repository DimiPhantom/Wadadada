using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_BuyButton : MonoBehaviour {

	public Button BuyButton;
	// Use this for initialization
	void Start () {
		BuyButton.onClick.AddListener (PressedBuy);
	}
	void Update() {
		if (Script_Text.CharacterEnabled [Script_SingleSelect.NowNum-1]) {
			BuyButton.enabled = false;
			BuyButton.GetComponent<Image> ().enabled = false;
		} else {
			BuyButton.enabled = true;
			BuyButton.GetComponent<Image> ().enabled = true;
		}
	}
	void PressedBuy() {
		if (Script_Text.CharacterPrice[Script_SingleSelect.NowNum-1] <= Script_Variables.money) {
			BuyButton.enabled = false;
			BuyButton.GetComponent<Image> ().enabled = false;
			Script_Variables.money-=Script_Text.CharacterPrice[Script_SingleSelect.NowNum-1];
			EncryptedPlayerPrefs.SetInt("Character"+(Script_SingleSelect.NowNum-1), 1);
			Script_Text.CharacterEnabled[Script_SingleSelect.NowNum-1] = true;
		}
	}
}
