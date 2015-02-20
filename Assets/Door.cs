using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public static bool key_found = false;
	public float waitTime = 2f;

	void OnMouseDown() {
		if (key_found) {
			print ("Clicked");
			StartCoroutine (gamePauseTime ());
			GetComponent<SpriteRenderer> ().color = Color.black;
		} else
			print ("Need Key");

	}

	IEnumerator gamePauseTime() {
		yield return new WaitForSeconds (waitTime);
		openDoor ();
	}

	void openDoor() {
		Application.LoadLevel ("_Scene_1");
	}

}
