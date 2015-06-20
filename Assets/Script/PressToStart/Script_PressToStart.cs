using UnityEngine;
using System.Collections;

public class Script_PressToStart : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.touchCount>0) {
			Application.LoadLevel ("Start");
		}
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
}
