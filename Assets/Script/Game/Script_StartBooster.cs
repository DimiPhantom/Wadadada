using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_StartBooster : MonoBehaviour {

	public Text DistanceText;
	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (0.1f);
		if (Script_Variables.item [0]) {
			for(int i=0;i<100;i++)
			{
				yield return new WaitForSeconds(0.01f);
				i++;
				if(Script_Variables.highscore<i)
				{
					Script_Variables.highscore=i;
				}
				Script_Variables.distance=i;
				DistanceText.text = "최고 : "+Script_Variables.highscore+"걸음\n현재 : "+i+"걸음";
			}
		}
		yield return null;
	}
}
