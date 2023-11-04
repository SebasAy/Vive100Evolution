using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bebida2 : Bebida
{
    public override int CalcularValorMoneda()
    {
        base.CalcularValorMoneda();
        Valor= Valor * 2;
        return Valor;
    }
}
