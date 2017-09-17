using System.Collections;
using System.Collections.Generic;

public class Player {
    private string nome;
    private int[] decisoes;
    private int humor;
    private float saldo;
    private float saldoAnterior;
    private int medidorHumor;

    public void setMedidorHumor(int medH)
    {
        this.medidorHumor = medH;
    }

    public int getMedidorHumor()
    {
        return this.medidorHumor;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public void setDecisoes(int decisao)
    {
        this.decisoes[decisoes.Length] = decisao;
    }

    public void setHumor(int medHumor)
    {
        if (medHumor > 0)
            this.humor = 1;
        else if (medHumor > 30)
            this.humor = 0;
        else
            this.humor = -1;
    }

    public void setSaldo(float saldo)
    {
        this.saldo = saldo;
    }

    public void setSaldoAnterior(float saldoAnterior)
    {
        this.saldoAnterior = saldoAnterior;

    }

    public string getNome()
    {
        return this.nome;
    }

    public int getHumor()
    {
        return this.humor;
    }

    public float getSaldo()
    {
        return this.saldo;
    }

    public float getSaldoAnterior()
    {
        return this.saldoAnterior;
    }
}
