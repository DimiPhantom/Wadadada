using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Hammer : MonoBehaviour {
	
	public Image Shield;

	public Image Star1;
	public Image Star2;
	public Image Star3;
	public Image Star4;

	public Image TouchLeft;
	public Image TouchRight;

	public Animation animation;
	

	// Use this for initialization
	void Start () {
		Star1.enabled=false;
		Star2.enabled=false;
		Star3.enabled=false;
		Star4.enabled=false;//이펙트 숨기기

		GetComponent<Image> ().enabled = false;
		Shield.enabled = false;
		StartCoroutine (HammerMove ());
		GetComponent<Button> ().onClick.AddListener (Clicked);
	}
	void Clicked()
	{
		GetComponent<Image> ().enabled = false;
	}
	IEnumerator HammerMove()
	{
		while (true) {
			if(GetComponent<Image>().enabled)
			{
				if(Script_Variables.item[2])
				{
					Script_Variables.item[2]=false;
					Shield.enabled=true;
					for(int i=0;i<10;i++)
					{
						Shield.color=new Vector4(1,1,1,i/10.0f);
						yield return new WaitForSeconds(0.05f);
					}
					for(int i=0;i<10;i++)
					{
						Shield.color=new Vector4(1,1,1,(10-i)/10.0f);
						yield return new WaitForSeconds(0.05f);
					}
					for(int i=0;i<10;i++)
					{
						Shield.color=new Vector4(1,1,1,i/10.0f);
						yield return new WaitForSeconds(0.05f);
					}
					for(int i=0;i<10;i++)
					{
						Shield.color=new Vector4(1,1,1,(10-i)/10.0f);
						yield return new WaitForSeconds(0.05f);
					}
					Shield.enabled=false;
				}
				else
				{
					Handheld.Vibrate();
					Star1.enabled=true;
					Star2.enabled=true;
					Star3.enabled=true;
					Star4.enabled=true;

					bool Left;
					if(TouchLeft.enabled)
					{
						Left=true;
						TouchLeft.enabled=false;
					}
					else
					{
						Left=false;
						TouchRight.enabled=false;
					}

					Star1.GetComponent<Animator>().SetTrigger("Stunned");
					Star2.GetComponent<Animator>().SetTrigger("Stunned");
					Star3.GetComponent<Animator>().SetTrigger("Stunned");
					Star4.GetComponent<Animator>().SetTrigger("Stunned");


					Script_Variables.isStunned=true;
					yield return new WaitForSeconds(2.1f);
					Script_Variables.isStunned=false;

					if(Left)
					{
						TouchLeft.enabled=true;
					}
					else
					{
						TouchRight.enabled=true;
					}

					Star1.enabled=false;
					Star2.enabled=false;
					Star3.enabled=false;
					Star4.enabled=false;
				}
			}
			GetComponent<Image>().enabled=false;
			yield return new WaitForSeconds (Random.Range (10, 15));
			GetComponent<Image>().enabled=true;
			GetComponent<Animator>().speed=(Script_Variables.distance/200.0f)+1.0f;
			GetComponent<Animator>().SetTrigger("Play");
			yield return new WaitForSeconds(1.8f/((Script_Variables.distance/200.0f)+1.0f));
		}
	}
}
