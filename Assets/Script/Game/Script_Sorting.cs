using UnityEngine;
using System.Collections;

public class Script_Sorting : MonoBehaviour {

	public GameObject[] Objects;
	// Update is called once per frame
	void Update () {
		if (Objects [0].transform.position.x > Objects [1].transform.position.x 
			&& Objects [1].transform.position.x > Objects [2].transform.position.x) {
			Objects [0].GetComponent<SpriteRenderer> ().sortingOrder = 2;
			Objects [1].GetComponent<SpriteRenderer> ().sortingOrder = 3;
			Objects [2].GetComponent<SpriteRenderer> ().sortingOrder = 4;
		} else if (Objects [0].transform.position.x > Objects [2].transform.position.x
			&& Objects [2].transform.position.x > Objects [1].transform.position.x) {
			Objects [0].GetComponent<SpriteRenderer> ().sortingOrder = 2;
			Objects [1].GetComponent<SpriteRenderer> ().sortingOrder = 4;
			Objects [2].GetComponent<SpriteRenderer> ().sortingOrder = 3;
		} else if (Objects [1].transform.position.x > Objects [0].transform.position.x
			&& Objects [0].transform.position.x > Objects [2].transform.position.x) {
			Objects [0].GetComponent<SpriteRenderer> ().sortingOrder = 3;
			Objects [1].GetComponent<SpriteRenderer> ().sortingOrder = 2;
			Objects [2].GetComponent<SpriteRenderer> ().sortingOrder = 4;
		} else if (Objects [1].transform.position.x > Objects [2].transform.position.x
			&& Objects [2].transform.position.x > Objects [0].transform.position.x) {
			Objects [0].GetComponent<SpriteRenderer> ().sortingOrder = 4;
			Objects [1].GetComponent<SpriteRenderer> ().sortingOrder = 2;
			Objects [2].GetComponent<SpriteRenderer> ().sortingOrder = 3;
		} else if (Objects [2].transform.position.x > Objects [0].transform.position.x
			&& Objects [0].transform.position.x > Objects [1].transform.position.x) {
			Objects [0].GetComponent<SpriteRenderer> ().sortingOrder = 3;
			Objects [1].GetComponent<SpriteRenderer> ().sortingOrder = 4;
			Objects [2].GetComponent<SpriteRenderer> ().sortingOrder = 2;
		} else if (Objects [2].transform.position.x > Objects [1].transform.position.x
			&& Objects [1].transform.position.x > Objects [0].transform.position.x) {
			Objects [0].GetComponent<SpriteRenderer> ().sortingOrder = 4;
			Objects [1].GetComponent<SpriteRenderer> ().sortingOrder = 3;
			Objects [2].GetComponent<SpriteRenderer> ().sortingOrder = 2;
		}

		if (Objects [3].transform.position.x > Objects [4].transform.position.x 
		    && Objects [4].transform.position.x > Objects [5].transform.position.x) {
			Objects [3].GetComponent<SpriteRenderer> ().sortingOrder = 4;
			Objects [4].GetComponent<SpriteRenderer> ().sortingOrder = 3;
			Objects [5].GetComponent<SpriteRenderer> ().sortingOrder = 2;
		} else if (Objects [3].transform.position.x > Objects [5].transform.position.x
		           && Objects [5].transform.position.x > Objects [4].transform.position.x) {
			Objects [3].GetComponent<SpriteRenderer> ().sortingOrder = 4;
			Objects [4].GetComponent<SpriteRenderer> ().sortingOrder = 2;
			Objects [5].GetComponent<SpriteRenderer> ().sortingOrder = 3;
		} else if (Objects [4].transform.position.x > Objects [3].transform.position.x
		           && Objects [3].transform.position.x > Objects [5].transform.position.x) {
			Objects [3].GetComponent<SpriteRenderer> ().sortingOrder = 3;
			Objects [4].GetComponent<SpriteRenderer> ().sortingOrder = 4;
			Objects [5].GetComponent<SpriteRenderer> ().sortingOrder = 2;
		} else if (Objects [4].transform.position.x > Objects [5].transform.position.x
		           && Objects [5].transform.position.x > Objects [3].transform.position.x) {
			Objects [3].GetComponent<SpriteRenderer> ().sortingOrder = 2;
			Objects [4].GetComponent<SpriteRenderer> ().sortingOrder = 4;
			Objects [5].GetComponent<SpriteRenderer> ().sortingOrder = 3;
		} else if (Objects [5].transform.position.x > Objects [3].transform.position.x
		           && Objects [3].transform.position.x > Objects [4].transform.position.x) {
			Objects [3].GetComponent<SpriteRenderer> ().sortingOrder = 3;
			Objects [4].GetComponent<SpriteRenderer> ().sortingOrder = 2;
			Objects [5].GetComponent<SpriteRenderer> ().sortingOrder = 4;
		} else if (Objects [5].transform.position.x > Objects [4].transform.position.x
		           && Objects [4].transform.position.x > Objects [3].transform.position.x) {
			Objects [3].GetComponent<SpriteRenderer> ().sortingOrder = 2;
			Objects [4].GetComponent<SpriteRenderer> ().sortingOrder = 3;
			Objects [5].GetComponent<SpriteRenderer> ().sortingOrder = 4;
		}

	}
}
