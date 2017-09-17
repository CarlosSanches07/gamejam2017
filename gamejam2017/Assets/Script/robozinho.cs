using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robozinho : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    string Robo (int[] decisoes, float saldo, float saldoAnterior, int humor)
    {
        bool d;
        bool s;
        bool h;
        bool fatorPessoal;
        string mensagem = "";
        int fDecisão = 0;

        for(int i = 0; i < decisoes.Length; i++)
        {
            fDecisão += decisoes[i];
        }

        d = (fDecisão > 0) ? true : false;
        s = (saldo > saldoAnterior) ? true : false;
        h = (humor > 0) ? true : false;

        fatorPessoal = (d && h) ? true : false;

        if (fatorPessoal && s)
            mensagem = "Muito bem, parece que você está aprendendo a cuidar do seus bens";
        else
            if (s)
            mensagem = "Conseguir seus objetivos sem ser feliz será o suficiente ?";
        else
            if (fatorPessoal)
            mensagem = "As vezes ser feliz é mais importante que dinheiro, mas esse é o seu objetivo ?";
        else
            mensagem = "Você não aprendeu nada ? Que tal começarmos de novo ?";
       

        return mensagem;
    }
}
