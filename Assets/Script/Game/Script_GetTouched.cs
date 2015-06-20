using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_GetTouched : MonoBehaviour {

	public int nowRoad;

	public Image TouchLeft;
	public Image TouchRight;
	public Image Paused;
	public Image HP_Bar;
	public Text DistanceText;

	public GameObject[] Road;
	public GameObject[] Character;
	public GameObject[] Objects;

	// Use this for initialization
	void Start () {
		Script_Variables.highscore = PlayerPrefs.GetInt ("HighScore", 0);
		Script_Variables.distance = 0;
		nowRoad = 0;


		TouchLeft.enabled = true;//터치 버튼 보이게 하기 
		TouchRight.enabled = false;//터치 버튼 숨기기

		for (int i=0; i<4; i++) {
			Road [i].GetComponent<SpriteRenderer> ().enabled = false;
		}
		Road [0].GetComponent<SpriteRenderer> ().enabled = true;//첫번째 도로만 보이게 하기

		Character [0] = GameObject.Find ("C0");
		Character [1] = GameObject.Find ("C1");//게임 오브젝트 찾기(캐릭터)

		Character [0].GetComponent<SpriteRenderer> ().enabled = true;
		Character [1].GetComponent<SpriteRenderer> ().enabled = false;

		DistanceText.text = "최고 : "+Script_Variables.highscore+"걸음\n현재 : 0걸음";
		Objects [0].GetComponent<Animator> ().Play (0, 0, 0.1f);
		Objects [1].GetComponent<Animator> ().Play (0, 0, 0.4f);
		Objects [2].GetComponent<Animator> ().Play (0, 0, 0.76666f);
		Objects [3].GetComponent<Animator> ().Play (0, 0, 0.1f);
		Objects [4].GetComponent<Animator> ().Play (0, 0, 0.4f);
		Objects [5].GetComponent<Animator> ().Play (0, 0, 0.76666f);
		foreach (GameObject i in Objects) {
			i.GetComponent<Animator> ().StartPlayback ();
		}

	}
	void Update()
	{
		if (!Paused.enabled && !Script_Variables.isStunned && Input.touchCount>=1) {
			if (TouchLeft.GetComponent<Image> ().enabled == true) {
				if (Input.GetTouch (0).position.x * Input.GetTouch (0).position.x 
				    + Input.GetTouch (0).position.y * Input.GetTouch (0).position.y <= Screen.width*Screen.width/7) {
					StartCoroutine(Touch ());
				}
			} else {
				if ((Input.GetTouch (0).position.x - Screen.width) * (Input.GetTouch (0).position.x - Screen.width) 
				    + Input.GetTouch (0).position.y * Input.GetTouch (0).position.y <= Screen.width*Screen.width/7) {
					StartCoroutine(Touch ());
				}
			}
		}
	}
	IEnumerator Touch()
	{
		TouchLeft.enabled = !TouchLeft.enabled;
		TouchRight.enabled = !TouchRight.enabled;//번갈아가면서 바꾸기

		Character [0].GetComponent<SpriteRenderer> ().enabled = 
			!Character [0].GetComponent<SpriteRenderer> ().enabled;
		Character [1].GetComponent<SpriteRenderer> ().enabled = 
			!Character [1].GetComponent<SpriteRenderer> ().enabled;//번갈아가면서 바꾸기


		if (nowRoad > 2) {
			nowRoad = 0;
		} else {
			nowRoad++;
		}
		for (int i=0; i<4; i++) {
			Road [i].GetComponent<SpriteRenderer> ().enabled = false;
		}
		Road[nowRoad].GetComponent<SpriteRenderer> ().enabled = true;//도로 계속 바꾸기

		Script_Variables.distance++;

		if (Script_Variables.highscore < Script_Variables.distance) {
			Script_Variables.highscore = Script_Variables.distance;
		}

		HP_Bar.SendMessage ("Pressed");

		DistanceText.text = "최고 : "+Script_Variables.highscore+"걸음\n현재 : "+Script_Variables.distance + "걸음";
		foreach (GameObject i in Objects) {
			i.GetComponent<Animator> ().StopPlayback ();
		}
		yield return null;
		foreach (GameObject i in Objects) {
			i.GetComponent<Animator> ().StartPlayback ();
		}

	}
}
