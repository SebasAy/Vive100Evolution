using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bebida7 : Bebida
{
    public override int CalcularValorMoneda()
    {
        base.CalcularValorMoneda();
        Valor= Valor * 7;
        return Valor;
    }
}
