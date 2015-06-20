using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_ExpItem : MonoBehaviour {

	public Image ExpImage;
	// Use this for initialization
	IEnumerator Start () {
		if (Script_Variables.item [3]) {//아이템 설정 되어 있을 때
			//페이드인 및 페이드아웃
			ExpImage.enabled=true;
			for(float i=0;i<1;i+=0.03f)
			{
				ExpImage.color=new Vector4(1,1,1,i);
				yield return new WaitForSeconds(0.01f);
			}
			for(float i=0;i<1;i+=0.03f)
			{
				ExpImage.color=new Vector4(1,1,1,1-i);
				yield return new WaitForSeconds(0.01f);
			}
			for(float i=0;i<1;i+=0.03f)
			{
				ExpImage.color=new Vector4(1,1,1,i);
				yield return new WaitForSeconds(0.01f);
			}
			for(float i=0;i<1;i+=0.03f)
			{
				ExpImage.color=new Vector4(1,1,1,1-i);
				yield return new WaitForSeconds(0.01f);
			}
		} else {
			ExpImage.enabled=false;//숨기기
		}
		yield return null;
	}
}
