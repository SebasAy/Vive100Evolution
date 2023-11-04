using System;
using UnityEngine;

public class Bebida:MonoBehaviour
{
    public int ValorMoneda { get; private set; }
    public int Multiplicador;
    public int Valor;

    public Bebida()
    {
        ValorMoneda = CalcularValorMoneda();
    }

    public virtual int CalcularValorMoneda()
    {
        Multiplicador = 1;
        Valor = 1 * Multiplicador;
        return Valor;
    }
}