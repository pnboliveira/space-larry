using UnityEngine;
using System.Collections;

public class controllerPersonagem : MonoBehaviour {
	private float direcao;
	public float VelocidadeDeslocacao = 10f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float direcao = Input.GetAxis("Horizontal") * VelocidadeDeslocacao;
		transform.Translate (direcao, 0, 0);
		if (Input.GetKeyDown("r")) //Caso o Jogador carregue na tecla R durante o jogo todo
		{
			Application.LoadLevel("lvl1");	//Volta para o nível 1
		}
	}
}