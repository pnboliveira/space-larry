using UnityEngine;
using System.Collections;

public class controladorPersonagem : MonoBehaviour {
	[HideInInspector] public bool salto=false;
	[HideInInspector] public bool orientacaoDireita = true;

	public float velocidade = 0.1f;
	public float direcao = 5f;
	private float forcaMove = 1500f;
	private float forcaSalto = 450f;
	public Transform groundCheck;
	private Animator ControladorAnimacao;
	private Rigidbody2D rb2d;
	private bool grounded = false;




	// Use this for initialization
	void Awake () 
	{
		ControladorAnimacao = gameObject.GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D>();
	}


    // Update is called once per frame
	void Update () 
	{
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Plataforma"));
		
		if (Input.GetButtonDown("Jump") && grounded)
		{
			salto = true;
		}
	}

	void FixedUpdate () 
	{
	//	direcao = Input.GetAxis ("Horizontal") * velocidade;
		float h = direcao;
		if (h * rb2d.velocity.x < direcao)
			rb2d.AddForce(Vector2.right * h * forcaMove);
		if (Mathf.Abs (rb2d.velocity.x) > direcao)
			rb2d.velocity = new Vector2(Mathf.Sign (rb2d.velocity.x) * direcao, rb2d.velocity.y);
		// Adicionar um incremento para contar as plataformas que o Player colidde, aumentando a sua velocidade

		Debug.Log(grounded);

		if (salto)
		{
			rb2d.AddForce(new Vector2(0f, forcaSalto));
			salto = false;
		}

		if (grounded || salto == true) 
		{
			direcao += Time.deltaTime /16;
		}

		if (Input.GetKeyDown("r"))  //Caso o Jogador carregue na tecla R durante o jogo todo
		{
			Application.LoadLevel(Application.loadedLevel);	//Volta para o nível 1
		}
		ControladorAnimacao.SetFloat ("deslocacaoPersonagem", direcao);
	}
}
