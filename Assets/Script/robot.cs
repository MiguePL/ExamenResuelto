using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot : MonoBehaviour {
	Rigidbody2D misco;
	SpriteRenderer sprite_robot;
	public float velocidad = 5;

	// Use this for initialization
	void Start () {
		misco = GetComponent<Rigidbody2D> ();
		sprite_robot = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			misco.velocity = new Vector2 (-velocidad, 0);
			sprite_robot.flipX = true;
		
	}
		if (Input.GetKey (KeyCode.RightArrow)) {
			misco.velocity = new Vector2 (velocidad, 0);
			sprite_robot.flipX = false;
		}
	}
}
