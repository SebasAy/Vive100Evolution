using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class MergeBebida : MonoBehaviour
{
    public GameObject prefabFusionada;
    public bool CanMerge(GameObject bebida1, GameObject bebida2)
    {
        if (bebida1.CompareTag("Bebidas") && bebida2.CompareTag("Bebidas"))
        {
            float distancia = Vector3.Distance(bebida1.transform.position, bebida2.transform.position);
            // Establece una distancia límite para la fusión (ajusta esto según tus necesidades).
            float distanciaLimite = 2.0f;
            return distancia <= distanciaLimite;
        }
        return false;
    }
    public void MergeBebidas(GameObject bebida1, GameObject bebida2)
    {
        Destroy(bebida1);
        Destroy(bebida2);

        Instantiate(prefabFusionada, (bebida1.transform.position + bebida2.transform.position) / 2, Quaternion.identity);
    }
}

