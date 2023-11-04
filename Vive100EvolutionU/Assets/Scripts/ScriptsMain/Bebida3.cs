using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bebida3 : Bebida
{
    public override int CalcularValorMoneda()
    {
        base.CalcularValorMoneda();
        Valor= Valor * 3;
        return Valor;
    }
}
