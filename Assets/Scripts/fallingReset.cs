using UnityEngine;
using System.Collections;

public class fallingReset : MonoBehaviour {

	private controladorPersonagem kid;
	private bool coli;

	// Use this for initialization
	void Start () {
		coli = false;
		kid = GameObject.Find("heroi").GetComponent<controladorPersonagem>();

	}

	void OnTriggerEnter2D (Collider2D other) {
		if (kid.gameObject.tag == "Player") {
			coli = true;
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		if (kid.gameObject.tag == "Player") {
			coli = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (coli == true) 
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
