using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoJ2 : MonoBehaviour {
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
		if (Input.GetKey (KeyCode.W)) {
			vertical = 10;
		}

		if (Input.GetKey (KeyCode.S)) {
			vertical = -10;
		}

		if (Input.GetKey (KeyCode.A)) {
			horizontal = -10;
		}

		if (Input.GetKey (KeyCode.D)) {
			horizontal = 10;
		}

		//-------------------GETKEYUP---------------------
		if (Input.GetKeyUp (KeyCode.W)) {
				vertical = 0;
		}

		if (Input.GetKeyUp (KeyCode.S)) {
				vertical = 0;
		}

		if (Input.GetKeyUp (KeyCode.A)) {
				horizontal = 0;
		}

		if (Input.GetKeyUp (KeyCode.D)) {
				horizontal = 0;
		}
		rb.velocity = new Vector2 (horizontal, vertical);
	}
}
