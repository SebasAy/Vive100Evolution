using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class MergeBebida : MonoBehaviour
{
    public GameObject prefab2;
    public GameObject prefab3;
    public GameObject prefab4;
    public GameObject prefab5;
    public GameObject prefab6;
    public GameObject prefab7;
    public GameObject prefab8;
    public GameObject nuevaBebidaFusionada;
    public bool CanMerge(GameObject bebida1, GameObject bebida2)
    {
        if (bebida1.tag == bebida2.tag)
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

        if (bebida1.CompareTag("Bebida1"))
        {
            nuevaBebidaFusionada = Instantiate(prefab2, (bebida1.transform.position + bebida2.transform.position) / 2, Quaternion.identity);
        }
        else if (bebida1.CompareTag("Bebida2"))
        {
            nuevaBebidaFusionada = Instantiate(prefab3, (bebida1.transform.position + bebida2.transform.position) / 2, Quaternion.identity);
        }
        else if (bebida1.CompareTag("Bebida3"))
        {
            nuevaBebidaFusionada = Instantiate(prefab4, (bebida1.transform.position + bebida2.transform.position) / 2, Quaternion.identity);
        }
        else if (bebida1.CompareTag("Bebida4"))
        {
            nuevaBebidaFusionada = Instantiate(prefab5, (bebida1.transform.position + bebida2.transform.position) / 2, Quaternion.identity);
        }
        else if (bebida1.CompareTag("Bebida5"))
        {
            nuevaBebidaFusionada = Instantiate(prefab6, (bebida1.transform.position + bebida2.transform.position) / 2, Quaternion.identity);
        }
        else if (bebida1.CompareTag("Bebida6"))
        {
            nuevaBebidaFusionada = Instantiate(prefab7, (bebida1.transform.position + bebida2.transform.position) / 2, Quaternion.identity);
        }
        else if (bebida1.CompareTag("Bebida7"))
        {
            nuevaBebidaFusionada = Instantiate(prefab8, (bebida1.transform.position + bebida2.transform.position) / 2, Quaternion.identity);
        }
    }
}

