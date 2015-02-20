using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

	void OnMouseDown() {
		Door.key_found = true;
		Destroy (gameObject);

	}
}
