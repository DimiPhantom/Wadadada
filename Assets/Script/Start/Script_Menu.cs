using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Menu : MonoBehaviour {

	public Text GameNameText;

	public Button Button_Single;
	public Button Button_Multi;
	public Button Button_Quit;
	

	void Start () {
		Script_Variables.money=EncryptedPlayerPrefs.GetInt ("Money", 0);
		Script_Variables.NickName = EncryptedPlayerPrefs.GetString ("NickName", "");
		Script_Variables.level = EncryptedPlayerPrefs.GetInt ("Level", 1);
		Script_Variables.exp = EncryptedPlayerPrefs.GetInt ("Exp", 0);
		Script_Variables.highscore = EncryptedPlayerPrefs.GetInt ("HighScore", 0);

		Button_Single.onClick.AddListener (SingleClicked);
		Button_Multi.onClick.AddListener (RankClicked);
		Button_Quit.onClick.AddListener (QuitClicked);//버튼 이벤트 추가

	}
	void SingleClicked()
	{
		Application.LoadLevel ("Shop");//싱글 샵으로
	}
	void RankClicked()
	{
		if (Script_Variables.NickName!="") {
			Application.LoadLevel("Rank");//랭크 페이지
		}
		else {
			Application.LoadLevel ("MultiFirstJoin");//멀티 닉네임 전송
		}
	}
	void QuitClicked()
	{
		Application.Quit ();//종료
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit();
		}
	}
}
