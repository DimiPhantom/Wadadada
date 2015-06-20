using UnityEngine;
using System.Collections;

public class Script_Character : MonoBehaviour {

	public GameObject temp;
	// Use this for initialization
	void Start () {
		for (int i=0; i<2; i++) {
			temp=Instantiate (Resources.Load ("Character/C" + Script_Variables.CharacterName + "/C"+i)) as GameObject;//캐릭터 가져오기
			temp.transform.parent = transform;
			temp.transform.localPosition=new Vector3(0,0,0);
			if(Script_Variables.CharacterName==5)//뱀의 경우에는
			{
				temp.transform.localScale=new Vector3(2,2,2);//2배
			}
			else
			{
				temp.transform.localScale=new Vector3(1,1,1);
			}
			temp.GetComponent<SpriteRenderer>().sortingLayerName = "Character";//캐릭터로 정렬
			temp.transform.name="C"+i;//캐릭터 이름
		}
	}
}
