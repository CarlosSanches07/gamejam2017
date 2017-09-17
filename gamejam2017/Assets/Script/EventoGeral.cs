using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EventoGeral : MonoBehaviour {

    public GameObject[] go;
    public string[] pergunta;
    public string[] botao1;
    public string[] botao2;
    public string[] botao3;
    public Text btnEscolha1;
    public Text btnEscolha2;
    public Text btnEscolha3;
    public Text txtPergunta;





    // Use this for initialization
    void Start () {
        int i = Random.Range(0, pergunta.Length);
        btnEscolha1.text = botao1[i];
        btnEscolha2.text = botao2[i];
        btnEscolha3.text = botao3[i];
        txtPergunta.text = pergunta[i];

    }

    public void Escolha1()
    {
		GameObject goBtn = GameObject.Find ("Escolha1") as GameObject;
		Text txt = goBtn.GetComponent<Text>();
		debitar(txt.text);
    }
	public void Escolha2()
	{
		GameObject goBtn = GameObject.Find ("Escolha2") as GameObject;
		Text txt = goBtn.GetComponent<Text>();
		debitar(txt.text);
	}
	public void Escolha3()
	{
		GameObject goBtn = GameObject.Find ("Escolha3") as GameObject;
		Text txt = goBtn.GetComponent<Text>();
		debitar(txt.text);
	}

	void debitar(string s){
		if (s == "") {
			GameManager.instance.money += 10;
			GameManager.instance.happy -= 10;

		}
		if (s == "Bicicleta") {
			GameManager.instance.money += 1;
			GameManager.instance.happy -= 1;

		}
		if (s == "Onibus") {
			GameManager.instance.money += 2;
			GameManager.instance.happy -= 2;

		}
		if (s == "Carro") {
			GameManager.instance.money += 3;
			GameManager.instance.happy -= 3;

		}
		if (s == "Podrão R$ 5,00") {
			GameManager.instance.money -= 5;
			GameManager.instance.happy -= 1;

		}
        if (s == "Marmita R$ 10,00")
        {
            GameManager.instance.money -= 10;
            GameManager.instance.happy -= 0;

        }
        if (s == "Marmita R$ 10,00")
        {
            GameManager.instance.money -= 10;
        }

        if (s == "Restaurante R$ 55,00")
        {
            GameManager.instance.money -= 55;
            GameManager.instance.happy += 1;

        }
        if (s == "")
        {
            GameManager.instance.money += 10;
            GameManager.instance.happy -= 10;

        }
        if (s == "")
        {
            GameManager.instance.money += 10;
            GameManager.instance.happy -= 10;

        }
        if (s == "")
        {
            GameManager.instance.money += 10;
            GameManager.instance.happy -= 10;

        }

        SceneManager.LoadScene("Escolha");

    }


    // Update is called once per frame
    void Update () {
		
	}
}
