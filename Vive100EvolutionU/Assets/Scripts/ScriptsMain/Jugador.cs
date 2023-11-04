using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Jugador: MonoBehaviour
{
    public UiManager uiManager;
    public int Monedas;
    public Bebida bebida;

    public Jugador()
    {
        Monedas = 0;
    }
    private void Update()
    {
        uiManager.ActualizarTextoMonedas(Monedas);
    }
    public void CambioMultiplicador()
    {
        if (Monedas >= 50)
        {
            bebida.Multiplicador++;
            Monedas = Monedas - 50;
        }
    }
}