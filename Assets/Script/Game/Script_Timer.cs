using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Timer : MonoBehaviour {
	
	public Text TimerText;
	public int Timer;
	// Update is called once per frame
	IEnumerator Start()
	{
		yield return new WaitForSeconds (3.2f);
		Timer = 0;
		while (true) {
			TimerText.text = "시간 : " + Timer++.ToString();
			yield return new WaitForSeconds(1);
		}
	}
}
