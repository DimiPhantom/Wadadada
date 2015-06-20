using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_OKButton : MonoBehaviour {

	public Button OK;
	// Use this for initialization
	void Start () {
		OK.onClick.AddListener (delegate {
			Application.LoadLevel("Start");});//스타트 씬으로 돌아가기
	}
}
