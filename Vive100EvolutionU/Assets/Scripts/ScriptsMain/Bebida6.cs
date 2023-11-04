using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bebida6 : Bebida
{
    public override int CalcularValorMoneda()
    {
        base.CalcularValorMoneda();
        Valor= Valor * 6;
        return Valor;
    }
}
