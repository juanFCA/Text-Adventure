using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {
		text.text = "Seja Bem Vindo ao Jogo.\n\nPressione a Barra de Espaço\npara continuar";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			text.text = "Você está em frente a porta da residência de um Aristocrata, " +
			            "ela encontra-se entreaberta, diante de você há uma Jarra de " +
				        "Metal com sangue nela e no jardim pode-se ver pegadas medianas.\n\n" +
				        "Pressione E para entrar na Residência\n" + 
				        "Pressione J para analisar a Jarra\n" +
				        "Pressione S para seguir as Pegadas";
			
		}
	}
}
