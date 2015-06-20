using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_GetRank : MonoBehaviour {

	public Text RankText;
	public Text HighScoreText;
	// Use this for initialization
	IEnumerator Start () {
		WWW www = new WWW (Script_Variables.URL + "sendhighscore.php?name=" + WWW.EscapeURL(Script_Variables.NickName) + "&highscore=" + Script_Variables.highscore);
		yield return www;
		string[] person=www.text.Split (' ');//Space 단위로 자르기
		for (int i=0; i<person.Length-1; i+=2) {
			if(person[i].Equals(Script_Variables.NickName)) {
				Script_Variables.rank=i/2+1;//랭크 설정
			}
			if(i<=18)
			{
				RankText.text+=(i+1)/2+1+" "+person[i]+" "+person[i+1]+"\n";//출력하기
			}
		}

		if (Script_Variables.rank == 0) {
			HighScoreText.text = "내 이름 : " + Script_Variables.NickName + "\n내 점수 : " + Script_Variables.highscore + "\n순위 ?";//순위 미정
		} else {
			HighScoreText.text = "내 이름 : " + Script_Variables.NickName + "\n내 점수 : " + Script_Variables.highscore + "\n순위 " + Script_Variables.rank;//순위 받아옴
		}

	}
}
