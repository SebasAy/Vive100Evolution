using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bebida5 : Bebida
{
    public override int CalcularValorMoneda()
    {
        base.CalcularValorMoneda();
        Valor= Valor * 5;
        return Valor;
    }
}
