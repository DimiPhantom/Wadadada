using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Logo : MonoBehaviour {

	public Image LogoImage;
	// Use this for initialization
	IEnumerator Start () {
		for (float i=0; i<1; i+=0.01f) {
			yield return new WaitForSeconds (0.01f);
			LogoImage.color = new Vector4(1, 1, 1, i);//페이드 인
		}
		for (float i=1; i>=0; i-=0.01f) {
			yield return new WaitForSeconds (0.01f);
			LogoImage.color = new Vector4(1, 1, 1, i);//페이드 아웃
		}
		Application.LoadLevel ("PressToStart");
	}

}
