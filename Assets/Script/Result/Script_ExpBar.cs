using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_ExpBar : MonoBehaviour {

	public Image ExpBar;
	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (0.1f);
		float percent = (float)Script_Variables.exp / (Script_Variables.level * 40);
		ExpBar.rectTransform.sizeDelta=new Vector2(percent*200,50);//Exp 바 길이 설정
	}
}
