using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoJ1 : MonoBehaviour {
	Rigidbody2D rb;
	float vertical = 0f;
	float horizontal = 0f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		//-------------------GETKEYDOWN---------------------
		if (Input.GetKey (KeyCode.UpArrow)) {
			vertical = 10;
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			vertical = -10;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			horizontal = -10;
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			horizontal = 10;
		}

		//-------------------GETKEYUP---------------------
		if (Input.GetKeyUp (KeyCode.UpArrow)) {
				vertical = 0;
		}

		if (Input.GetKeyUp (KeyCode.DownArrow)) {
				vertical = 0;
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
				horizontal = 0;
		}

		if (Input.GetKeyUp (KeyCode.RightArrow)) {
				horizontal = 0;
		}
		rb.velocity = new Vector2 (horizontal, vertical);
	}
}
