using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_HighScore : MonoBehaviour {

	public Text HighScoreText;
	// Use this for initialization
	void Start () {
		Script_Variables.highscore = EncryptedPlayerPrefs.GetInt ("HighScore", 0);
		HighScoreText.text="최고점수 : "+Script_Variables.highscore;
	}
}
