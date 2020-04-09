using UnityEngine;
using UnityEngine.UI;
using System.Collections;
[ExecuteInEditMode]

public class ScorePontuacao : MonoBehaviour {
	public int pontos = 0;
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text> ().text = pontos.ToString ();
	}
}
