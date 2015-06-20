using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SaveNickName : MonoBehaviour {
	
	public Button OK1;
	public Button OK2;

	public InputField input;
	
	public Text NameText;
	public Text ContentText;

	void Start () {
		OK1.onClick.AddListener (delegate {
			StartCoroutine("SendName");});
		OK2.onClick.AddListener (Set);

		OK1.GetComponent<Image> ().enabled = true;
		OK2.GetComponent<Image> ().enabled = false;
	}
	void Set()
	{
		NameText.text = "닉네임";
		ContentText.text = "닉네임을 입력해주세요";

		input.transform.localPosition = new Vector3 (0, 133, 0);
		input.text = "";

		OK1.GetComponent<Image> ().enabled = true;
		OK2.GetComponent<Image> ().enabled = false;
	}
	IEnumerator SendName()//닉네임을 보낸다.
	{
		input.transform.localPosition = new Vector3 (1000, 133, 0);
		WWW www = new WWW (Script_Variables.URL+"insert.php?name="+WWW.EscapeURL(input.text));
		yield return www;
		if (www.text == "Success") {//다음 씬 넘어감
			EncryptedPlayerPrefs.SetString("NickName", input.text);
			Script_Variables.NickName=input.text;
			Application.LoadLevel("Rank");
		} else if (www.text == "Not Connected" || www.text=="") {//연결되지 않을 때
			NameText.text = "연결 실패";
			ContentText.text = "네트워크를 확인해주세요.";
		} else if (www.text == "Same name") {//이름이 같을 때
			NameText.text = "오류";
			ContentText.text = "같은 닉네임이 있습니다.";
		}

		OK1.GetComponent<Image> ().enabled = false;
		OK2.GetComponent<Image> ().enabled = true;
	}
}
