using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadronScript : MonoBehaviour {
	GameObject pringao;
	CarteraScript cartera_pringao;
	// Use this for initialization
	void Start () {
		pringao = GameObject.Find ("ricardito");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			cartera_pringao = pringao.GetComponent<CarteraScript> ();
			cartera_pringao.donacion (-5);
		}
	}
}