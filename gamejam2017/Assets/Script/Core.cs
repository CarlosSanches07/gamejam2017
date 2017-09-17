using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Core : MonoBehaviour {
    private int posicao;
    private int dia = 1;
    private List<Evento> eventos;
    private float rand;
    private int flag;
    Player player;

    //Eventos

    public GameObject eventoMan;
    public GameObject eventoTar;
    public GameObject eventoNoi;
    public GameObject eventoMed;
    public GameObject eventoMec;

    // Use this for initialization
    void Start () {
        player = new Player();
        Instantiate<GameObject>(eventoMan);
        //invoca o prefab de atualização de tela com o nome do jogo
        //Invoca o começo do jogo com as instruções do Sr. Miagy
        //set a flag pra 0
    }

    // Update is called once per frame
    void Update() {
        /* print(flag);
         if (flag == 0)
              //reinicia
              //chama miagy
         else if (flag == 1)
              {
                  print("?");
                  Instantiate<GameObject>(eventoMan);
                  flag = 2;
                  eventoManha(eventos);
                  posicao = 1;
              }
          else if (flag == 2)
          {
              eventoTarde(eventos);
              posicao = 2;
          }
          else if (flag == 3)
          {
              eventoNoite(eventos);
              posicao = 3;
          }
          else if (flag == 4)
              EventoMedico(eventos);
          else if (flag == 5)
              eventoMecanico(eventos);
          else if (flag == 6) ;
              // eventoFimdeSemana();
          else if (flag == 7) ;
              // cenaMiagy*/
    }

    public List<Evento> iniciaLista()
    {
        posicao = 0;
        eventos = new List<Evento>();
        //Cria os eventos principais de cada dia 
        Evento evento1 = new Evento("Ir ao Trabalho", 1, "Está na hora de ir ao trabalho amor, como você vai hoje?");
        Evento evento2 = new Evento("Almoçar", 2, "Está na hora do almoço, onde vamos comer hoje?");
        Evento evento3 = new Evento("Jantar", 3, "Está na hora do jantar, como vamos jantar hoje?");
        eventos = new List<Evento>();
        eventos.Add(evento1);
        eventos.Add(evento2);
        eventos.Add(evento3);
        return eventos;
    }
    public void bike()
    {
        rand = Random.Range(0, 100);
        //player.setDecisoes(1);
        if (rand < 20)
        {
            //player.setMedidorHumor(player.getMedidorHumor() - 30);
            Instantiate<GameObject>(eventoMed);
        }
        else
        {
            //player.setMedidorHumor(player.getMedidorHumor() + 30);
            //tela de deu bom(Viagem de bike foi sussa);
            Instantiate<GameObject>(eventoTar);
        }
    }
    public void eventoManha(List<Evento> eventos)
    {
        Instantiate<GameObject>(eventoMan);
        switch (eventos[posicao].getOpcao())
        {
            //vai de bike
            case 1:
                rand = Random.Range(0, 100);
                player.setDecisoes(1);
                if (rand < 20)
                {
                    player.setMedidorHumor(player.getMedidorHumor() - 30);
                    EventoMedico(eventos);
                }
                else
                {
                    player.setMedidorHumor(player.getMedidorHumor() + 30);
                    //tela de deu bom(Viagem de bike foi sussa);
                }
                break;
            //vai de busao
            case 2:
                player.setDecisoes(-1);
                player.setMedidorHumor(player.getMedidorHumor() - 30);
                //vai de busão diminui o humor e chega um pouquinho mais tarde.
                break;
            //vai de carro
            case 3:
                player.setDecisoes(1);
                //vai de carro gasta muito com gasolina
                rand = Random.Range(0, 100);
                if (rand < 20)
                {
                    //deu ruim o carro quebrou
                    player.setMedidorHumor(player.getMedidorHumor() - 30);
                    flag = 5;
                }
                else
                {
                    player.setMedidorHumor(player.getMedidorHumor() + 30);
                    //até que não peguei transito hoje
                }
                break;
        }
        flag = 2;
    }

    public void eventoTarde(List<Evento> eventos)
    {
        switch (eventos[posicao].getOpcao())
        {
            //come prodrao
            case 1:
                player.setDecisoes(-1);
                rand = Random.Range(0, 100);
                if (rand < 50)
                {
                    //Deu ruim invoka banheiro
                    player.setMedidorHumor(player.getMedidorHumor() - 30);
                    flag = 4;
                }
                else
                {
                    player.setMedidorHumor(player.getMedidorHumor() + 30);
                    //deu bom segue o baile
                }
                break;
            //vai de marmita
            case 2:
                player.setDecisoes(1);
                player.setMedidorHumor(player.getMedidorHumor() - 30);
                //da sempre bom segue o baile
                break;
            //restaurante
            case 3:
                player.setDecisoes(-1);
                rand = Random.Range(0, 100);
                if (rand < 20)
                {
                    //deu ruim comida zoada
                    player.setMedidorHumor(player.getMedidorHumor() - 30);
                    flag = 4;
                }
                else
                {
                    player.setMedidorHumor(player.getMedidorHumor() + 30);
                }
                break;
        }
    }

    public void eventoNoite(List<Evento> eventos)
    {
        switch (eventos[posicao].getOpcao())
        {
            //come lanchão
            case 1:
                player.setDecisoes(1);
                rand = Random.Range(0, 100);
                if (rand < 50)
                {
                    //Deu ruim invoka banheiro
                    player.setMedidorHumor(player.getMedidorHumor() - 30);
                    flag = 4;
                }
                else
                {
                    player.setMedidorHumor(player.getMedidorHumor() + 30);

                }
                break;
            //comer em casa
            case 2:
                player.setDecisoes(-1);
                player.setMedidorHumor(player.getMedidorHumor() - 30);

                break;
            //restaurante
            case 3:
                player.setDecisoes(-1);
                rand = Random.Range(0, 100);
                if (rand < 20)
                {
                    //deu ruim comida zoada
                    player.setMedidorHumor(player.getMedidorHumor() - 30);
                    flag = 4;
                }
                else
                {
                    player.setMedidorHumor(player.getMedidorHumor() + 30);

                }
                break;
        }
        dia++;
        flag = 0;
    }

    public void eventoMecanico(List<Evento> eventos)
    {
        eventos[posicao -1].setSubEvento(new Evento("Mecanico", 4, "Parece que seu carro já era"));
        switch (eventos[posicao-1].getSubEvento().getOpcao())
        {
            //Primo
            case 1:
                player.setDecisoes(-1);
                rand = Random.Range(0, 100);
                if (rand < 70)
                {
                    player.setMedidorHumor(player.getMedidorHumor() - 30);
                }
                else
                {
                    player.setMedidorHumor(player.getMedidorHumor() + 30);
                }
                break;
            //Oficina
            case 2:
                player.setDecisoes(1);
                player.setMedidorHumor(player.getMedidorHumor() - 30);
                break;
            //PeçaUsada
            case 3:
                player.setDecisoes(-1);
                rand = Random.Range(0, 100);
                if (rand < 20)
                {
                    player.setMedidorHumor(player.getMedidorHumor() - 30);
                }
                else
                {
                    player.setMedidorHumor(player.getMedidorHumor() + 30);
                }
                break;
        }
    }

    public void EventoMedico(List<Evento> eventos)
    {
        eventos[posicao -1].setSubEvento(new Evento("Medico", 5, "Parece que não está bem, que tal comprar um remédio?"));
        switch (eventos[posicao -1].getSubEvento().getOpcao())
        {
            //Pegar com o amigo
            case 1:
                player.setDecisoes(-1);
                rand = Random.Range(0, 100);
                if (rand < 70)
                {
                    player.setMedidorHumor(player.getMedidorHumor() - 30);
                }
                else
                {
                    player.setMedidorHumor(player.getMedidorHumor() + 30);
                }
                break;
            //Médico
            case 2:
                player.setDecisoes(1);
                player.setMedidorHumor(player.getMedidorHumor() - 30);
                break;
            //Comprar na farmácia sem prescrição
            case 3:
                player.setDecisoes(-1);
                rand = Random.Range(0, 100);
                if (rand < 20)
                {
                    player.setMedidorHumor(player.getMedidorHumor() - 30);
                }
                else
                {
                    player.setMedidorHumor(player.getMedidorHumor() + 30);
                }
                break;
        }
    }
}
