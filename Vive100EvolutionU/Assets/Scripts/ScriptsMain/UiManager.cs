using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public TextMeshPro monedasText;

    public void ActualizarTextoMonedas(int cantidadMonedas)
    {
        monedasText.text = "Monedas: " + cantidadMonedas.ToString();
    }
}
