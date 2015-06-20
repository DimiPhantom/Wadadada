using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Item : MonoBehaviour {

	public Toggle ItemButton1;
	public Toggle ItemButton2;
	public Toggle ItemButton3;
	public Toggle ItemButton4;

	public Image ItemClicked1;
	public Image ItemClicked2;
	public Image ItemClicked3;
	public Image ItemClicked4;

	void Start()
	{
		ItemClicked1.enabled = false;
		ItemClicked2.enabled = false;
		ItemClicked3.enabled = false;
		ItemClicked4.enabled = false;

		ItemButton1.onValueChanged.AddListener (delegate{Item1Changed();});
		ItemButton2.onValueChanged.AddListener (delegate{Item2Changed();});
		ItemButton3.onValueChanged.AddListener (delegate{Item3Changed();});
		ItemButton4.onValueChanged.AddListener (delegate{Item4Changed();});
	}
	void Update()
	{
		if (Script_Variables.money >= 70) {
			ItemButton4.interactable = true;
		} else {
			ItemButton4.interactable = false;
		}
		if (Script_Variables.money >= 100) {
			ItemButton2.interactable = true;
			ItemButton1.interactable = true;
			ItemButton3.interactable = true;
		} else {
			ItemButton1.interactable = false;
			ItemButton3.interactable = false;
			ItemButton2.interactable = false;
		}
	}
	void Item1Changed()
	{
		if (ItemButton1.isOn) {
			ItemClicked1.enabled = true;
			Script_Variables.money -= 100;//스타트 부스터
		} else {
			ItemClicked1.enabled = false;
			Script_Variables.money += 100;
		}
	}
	void Item2Changed()
	{
		if (ItemButton2.isOn) {
			ItemClicked2.enabled = true;
			Script_Variables.money -= 100;//부활
		} else {
			ItemClicked2.enabled = false;
			Script_Variables.money += 100;
		}
	}
	void Item3Changed()
	{
		if (ItemButton3.isOn) {
			ItemClicked3.enabled = true;
			Script_Variables.money -= 100;//실드
		} else {
			ItemClicked3.enabled = false;
			Script_Variables.money += 100;
		}
	}
	void Item4Changed()
	{
		if (ItemButton4.isOn) {
			ItemClicked4.enabled = true;
			Script_Variables.money -= 70;//경험치 부스터
		} else {
			ItemClicked4.enabled = false;
			Script_Variables.money += 70;
		}
	}
}
