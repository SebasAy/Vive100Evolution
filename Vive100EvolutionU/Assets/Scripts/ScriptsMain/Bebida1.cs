using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bebida1 : Bebida
{
    public override int CalcularValorMoneda()
    {
        base.CalcularValorMoneda();
        Valor= Valor * 1;
        return Valor;
    }
}
