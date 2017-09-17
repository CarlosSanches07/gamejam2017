using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class vaca : MonoBehaviour {
    public Text txtLevel;
    public Text txtMoedas;
    public Text txtHumor;



    // Use this for initialization
    void Start () {
        txtLevel.text = "Level" + GameManager.instance.level + " concluido";
        txtMoedas.text = "Moedas: " + GameManager.instance.money;
        txtHumor.text = "Humor: " + GameManager.instance.happy;

    }

    // Update is called once per frame
    void Update () {
		
	}


    public void Cena()
    {

        SceneManager.LoadScene("Escolha");
    }
}
