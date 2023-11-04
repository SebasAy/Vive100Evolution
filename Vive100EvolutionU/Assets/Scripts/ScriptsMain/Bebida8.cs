using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bebida8 : Bebida
{
    public override int CalcularValorMoneda()
    {
        base.CalcularValorMoneda();
        Valor= Valor * 8;
        return Valor;
    }
}
