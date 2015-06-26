using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Coin : MonoBehaviour {

	public Button Coin;
	public Text CoinText;
	public ParticleSystem CoinDrop;
	// Use this for initialization
	IEnumerator Start () {
		CoinText.enabled=false;
		CoinDrop.Stop();
		Coin.onClick.AddListener (delegate { StartCoroutine(Clicked ()); });
		while (true) {
			Coin.GetComponent<Image> ().enabled = false;
			yield return new WaitForSeconds (Random.Range (15.0f, 20.0f));
			Coin.GetComponent<Image> ().enabled = true;
			Coin.GetComponent<Animator> ().Play (0,0,0);
			yield return new WaitForSeconds(2.1f);
		}
	}
	IEnumerator Clicked()
	{

		int random = Random.Range (10, 15);
		Script_Variables.money += random;

		CoinText.text = "+ " + random.ToString ();
		CoinText.enabled=true;
		CoinText.GetComponent<Animator> ().Play (0, 0, 0);
		CoinDrop.Play();
		Coin.GetComponent<Image> ().enabled = false;

		yield return new WaitForSeconds (1);
		CoinText.enabled=false;
		CoinDrop.Stop();
	}
}
