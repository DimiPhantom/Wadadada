using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Money : MonoBehaviour {

	public Text MoneyText;
	// Use this for initialization
	void Start(){
		Script_Variables.money=EncryptedPlayerPrefs.GetInt("Money", 0);
	}
	void Update () {
		MoneyText.text = Script_Variables.money.ToString();
	}

}
