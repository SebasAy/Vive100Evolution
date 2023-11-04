using System;
using UnityEngine;

public class Bebida:MonoBehaviour
{
    public int ValorMoneda { get; private set; }
    public int Valor;

    public Bebida()
    {
        ValorMoneda = CalcularValorMoneda();
    }

    public virtual int CalcularValorMoneda()
    {
        Valor = 1;
        return Valor;
    }
}