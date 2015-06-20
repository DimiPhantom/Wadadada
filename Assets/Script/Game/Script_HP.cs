using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_HP : MonoBehaviour {
	
	public float decreaseHp;
	public float increaseHpPerPress;
	
	public Image HP_Bar;
	public Image Revive;
	// Use this for initialization
	void Start () {
		Revive.enabled = false;
		Script_Variables.hp = 1;
		increaseHpPerPress = 0.0025f+Script_Variables.level*0.00015f;
		HP_Bar.rectTransform.sizeDelta = new Vector2 (819,67);
		InvokeRepeating ("HpProgress", 3.3f, 0.1f);
	}

	IEnumerator Revived()
	{
		Revive.rectTransform.localPosition = new Vector3 (-326, -88, 0);
		Revive.enabled = true;
		for (float i=0; i<1; i+=0.02f) {
			Revive.color=new Vector4(1,1,1,1-i);
			Revive.rectTransform.Translate (1, 1, 0);
			yield return new WaitForSeconds(0.01f);
		}
		Revive.enabled = false;
	}
	// Update is called once per frame
	void HpProgress () {
		Script_Variables.hp -= decreaseHp;
		if (Script_Variables.hp < 0) {
			if(Script_Variables.item[1])
			{
				StartCoroutine(Revived ());
				Script_Variables.item[1]=false;
				Script_Variables.hp=0.1f*Mathf.Floor(Script_Variables.level/10+1);
			}
			else
			{
				Application.LoadLevel("Result");
			}
		}
	}
	void Pressed()
	{
		Script_Variables.hp += increaseHpPerPress;
	}
	void Update()
	{
		decreaseHp = (Script_Variables.distance / 50 + Time.time / 50 + 1)*0.0002f;
		if (Script_Variables.hp > 1) {
			Script_Variables.hp = 1;
		}
		HP_Bar.rectTransform.sizeDelta = new Vector2 (819*Script_Variables.hp, 67);
	}
}
