using UnityEngine;
using System.Collections;

public class Script_EscapeKey : MonoBehaviour {
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))//뒤로 가기 눌렀을 때
		{
			Application.LoadLevel("Start");
		}
	}
}
