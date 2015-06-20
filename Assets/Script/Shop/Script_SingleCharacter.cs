using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_SingleCharacter : MonoBehaviour {

	void Update()
	{
		if (Input.touchCount < 1) {
			if(transform.position.x>0 && transform.position.x<Screen.width*160/200) {
				GetComponent<CanvasGroup> ().alpha = 1;
			} else {
				GetComponent<CanvasGroup> ().alpha = 0;
			}
		} else if(Input.GetTouch(0).position.y>Screen.height*200/320 && Input.GetTouch(0).position.y<Screen.height*300/320){
			GetComponent<CanvasGroup>().alpha=1;
		}
	}
}
