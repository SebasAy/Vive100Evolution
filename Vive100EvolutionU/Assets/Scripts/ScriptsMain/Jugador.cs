using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Jugador: MonoBehaviour
{
    public UiManager uiManager;
    public int Monedas;

    public Jugador()
    {
        Monedas = 0;
    }
    private void Update()
    {

        uiManager.ActualizarTextoMonedas(Monedas);
    }
}