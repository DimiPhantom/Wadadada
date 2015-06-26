using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Result : MonoBehaviour {

	public Text ResultText;
	public Text LevelText;
	public Text StatsText;

	public Image LevelUp;
	public Button OK;
	// Use this for initialization
	IEnumerator Start () {
		LevelUp.enabled = false;
		OK.onClick.AddListener (Pressed);
		yield return new WaitForSeconds (0.01f);

		Script_Variables.money += Script_Variables.distance / 10;

		if (Script_Variables.item [3]) {
			Script_Variables.exp += Script_Variables.distance / 4;
		} else {
			Script_Variables.exp += Script_Variables.distance / 8;
		}

		if (Script_Variables.exp >= Script_Variables.level*40) {
			int sum=0;
			int i;
			for(i=Script_Variables.level;;i++)
			{
				sum+=i;
				if(Script_Variables.exp<sum*40)
				{
					break;
				}
			}
			Script_Variables.exp-=(sum-i)*40;
			Script_Variables.level+=(i-Script_Variables.level);
			LevelUp.enabled=true;
			LevelUp.GetComponent<Animator>().SetTrigger("LevelUp");
			yield return new WaitForSeconds(1.5f);
			LevelUp.enabled=false;
		}
		
		EncryptedPlayerPrefs.SetInt ("Level", Script_Variables.level);
		EncryptedPlayerPrefs.SetInt ("Money",Script_Variables.money);
		EncryptedPlayerPrefs.SetInt ("Exp", Script_Variables.exp);
		EncryptedPlayerPrefs.SetInt ("HighScore", Script_Variables.highscore);

		ResultText.text = "현재 걸음 : " + Script_Variables.distance + "걸음\n최고 걸음 : " + Script_Variables.highscore+"걸음";
		LevelText.text = "Lv " + Script_Variables.level;
		StatsText.text = "[" + Script_Variables.exp + "/" 
			+ (40 * Script_Variables.level) + "]\n"
			+ (0.25f + (Script_Variables.level - 1) * 0.015f)+"\n"
			+ (100 + (Script_Variables.level - 1))+"%";

	}
	void Pressed() {
		Application.LoadLevel ("Shop");
	}
}
