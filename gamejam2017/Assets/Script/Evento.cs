using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evento{
    private string nome;
    private string mensagem;
    private int id;
    private Evento subevento;
    private int opcao;

    public Evento(string nome, int id, string mensgem)
    {
        this.nome = nome;
        this.id = id;
        this.mensagem = mensagem;
        this.opcao = 3;
        Evento subEvento;
    }

    public void setOpcao(int op)
    {
        this.opcao = op;
    }

    public int getOpcao()
    {
        return this.opcao;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public string getNome()
    {
        return this.nome;
    }

    public void setMensagem(string msg)
    {
        this.mensagem = msg;
    }

    public string getMensagem()
    {
        return this.mensagem;
    }

    public void setId(int id)
    {
        this.id = id;
    }

    public int getId()
    {
        return this.id;
    }

    public void setSubEvento(Evento evento)
    {
        this.subevento = evento;
    }

    public Evento getSubEvento()
    {
        return this.subevento;
    }
}
