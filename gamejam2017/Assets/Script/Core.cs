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

	// Use this for initialization
	void Start () {
        player = new Player();
        iniciaLista();
        //invoca o prefab de atualização de tela com o nome do jogo
        //Invoca o começo do jogo com as instruções do Sr. Miagy
        //set a flag pra 0
    }

    // Update is called once per frame
    void Update() {
            if(dia == 7)
                //chama miagy
            if (flag == 1)
                eventoManha(eventos);
            if (flag == 2)
                eventoTarde(eventos);
            if (flag == 3)
                eventoNoite(eventos);
        if (dia == 6) ;
                // eventoFimdeSemana();
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

    public void eventoManha(List<Evento> eventos)
    {
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
                    eventoMecanico(eventos);
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
                    EventoMedico(eventos);
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
                    EventoMedico(eventos);
                }
                else
                {
                    player.setMedidorHumor(player.getMedidorHumor() + 30);
                }
                break;
        }
        flag = 3;
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
                    EventoMedico(eventos);
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
                    EventoMedico(eventos);
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
        eventos[posicao].setSubEvento(new Evento("Mecanico", 4, "Parece que seu carro já era"));
        switch (eventos[posicao].getSubEvento().getOpcao())
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
        eventos[posicao].setSubEvento(new Evento("Medico", 5, "Parece que não está bem, que tal comprar um remédio?"));
        switch (eventos[posicao].getSubEvento().getOpcao())
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
