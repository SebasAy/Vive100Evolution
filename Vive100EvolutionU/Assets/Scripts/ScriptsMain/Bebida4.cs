using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bebida4 : Bebida
{
    public override int CalcularValorMoneda()
    {
        base.CalcularValorMoneda();
        Valor= Valor * 4;
        return Valor;
    }
}
