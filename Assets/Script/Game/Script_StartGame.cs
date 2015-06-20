using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_StartGame : MonoBehaviour {

	public Text Countdown;
	public Image WhiteImage;
	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (0.3f);
		WhiteImage.enabled = true;
		Countdown.enabled = true;
		for (int i=3; i>0; i--) {
			Countdown.text = i.ToString();
			yield return new WaitForSeconds (1.0f);
		}
		WhiteImage.enabled = false;
		Countdown.enabled = false;
	}
}
