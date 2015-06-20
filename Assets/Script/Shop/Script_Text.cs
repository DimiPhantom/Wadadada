using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Text : MonoBehaviour {

	public string[] CharacterInformation;
	public static int[] CharacterPrice;
	public static bool[] CharacterEnabled;
	public Text InfoText;
	public Image SelectedCharacter;
	void Start()
	{
		CharacterInformation = new string[16];
		CharacterPrice = new int[16];
		CharacterEnabled = new bool[16];

		for(int i=1;i<16;i++)
		{
			CharacterEnabled[i]=(EncryptedPlayerPrefs.GetInt("Character"+i, 0)==1?true:false);
		}

		CharacterEnabled [0] = true;
		
		CharacterInformation [0] = "이름:김기본\n빠른 달리기를 위해 머리를 밀었다고 한다\n";
		CharacterInformation [1] = "이름:다람\n척삭동물문 포유강 쥐목 다람쥣과\n";
		CharacterInformation [2] = "이름:꼬꼬\n날고 싶다\n";
		CharacterInformation [3] = "이름:Bob\n먹고 싶다\n";
		CharacterInformation [4] = "이름:길죽이\n길죽길죽한 뱀\n";
		CharacterInformation [5] = "이름:맛소금\n짜져\n";
		CharacterInformation [6] = "이름:사랑이\n따따따따\n";
		CharacterInformation [7] = "이름:궁둥\n오리날다\n";
		CharacterInformation [8] = "이름:조타\n타조타조타\n";
		CharacterInformation [9] = "이름:펭돌이\n끼룩끼룩\n";
		CharacterInformation [10] = "이름:게랑\n앞을 못 보는 슬픈 게\n";
		CharacterInformation [11] = "이름:Amy\n'야 어딨냐'\n";
		CharacterInformation [12] = "이름:목도리\n털털해\n";
		CharacterInformation [13] = "이름:대머리\n마지막 한 가닥을 위해 달리는 남자\n";
		CharacterInformation [14] = "이름:수켱\n세현이형";
		CharacterInformation [15] = "이름:켄타우루사\n보여줄 수도 없고...";

		CharacterPrice [0] = 0;
		CharacterPrice [1] = 1000;
		CharacterPrice [2] = 1400;
		CharacterPrice [3] = 700;
		CharacterPrice [4] = 700;
		CharacterPrice [5] = 1400;
		CharacterPrice [6] = 700;
		CharacterPrice [7] = 1400;
		CharacterPrice [8] = 2100;
		CharacterPrice [9] = 2100;
		CharacterPrice [10] = 700;
		CharacterPrice [11] = 1400;
		CharacterPrice [12] = 1000;
		CharacterPrice [13] = 2100;
		CharacterPrice [14] = 1000;
		CharacterPrice [15] = 2100;
	

	}
	void Update()
	{
		InfoText.text = CharacterInformation [Script_SingleSelect.NowNum-1];
		if (!CharacterEnabled [Script_SingleSelect.NowNum - 1]) {
			InfoText.text += "가격 : " + CharacterPrice [Script_SingleSelect.NowNum - 1];
		}
	}
}
