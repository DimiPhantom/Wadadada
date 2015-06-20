using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_SingleSelect : MonoBehaviour {

	public static int NowNum=0;
	public GameObject NowCharacter;
	public GameObject CharacterButton;

	public Image SelectedCharacter;
	void Update () {//240
		if (Input.touchCount > 0 && Input.GetTouch(0).position.y>Screen.height*200/320 && Input.GetTouch(0).position.y<Screen.height*300/320) {//터치 입력이 있을 때
			if (Input.GetTouch (0).phase == TouchPhase.Moved){ //이동을 하는 중이고

				Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition; //터치값의 변화량

				if ((touchDeltaPosition.x >= 0 && transform.localPosition.x >= 0)
					|| (touchDeltaPosition.x <= 0 && transform.localPosition.x <= -3525)) {

				} else {
					transform.Translate (touchDeltaPosition.x * 1.0f, 0, 0);//x값의 변화량만큼 움직임
				}
			}
		} else if (transform.localPosition.x > 0) {
			transform.localPosition = new Vector3 (0, 362, 0);
		} else if (transform.localPosition.x < -3525) {
			transform.localPosition = new Vector3 (-3525, 362, 0);//벗어났을 때
		} else {
			transform.localPosition=new Vector3(Mathf.Round(transform.localPosition.x/235)*235, 362, 0);//근처의 오브젝트로 지정

			NowNum=(int)Mathf.Round(transform.localPosition.x/235)*-1+1;//현재 선택된 캐릭터의 넘버
			NowCharacter=GameObject.Find("Character"+NowNum);//현재 선택된 캐릭터

			SelectedCharacter.sprite=NowCharacter.GetComponent<Image>().sprite;//이미지를 현재 선택된 캐릭터의 이미지로 설정

			//크기 설정
			SelectedCharacter.SetNativeSize();
			SelectedCharacter.transform.localScale=new Vector3(NowCharacter.transform.localScale.x*CharacterButton.transform.localScale.x*0.8f,
			                                                   NowCharacter.transform.localScale.y*CharacterButton.transform.localScale.y*0.8f, 
			                                                   NowCharacter.transform.localScale.z*CharacterButton.transform.localScale.z*0.8f);
		}
	}
}
