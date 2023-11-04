using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BebidaFactory : MonoBehaviour, Unity.VisualScripting.ISingleton
{
    public static BebidaFactory instance
    {
        get { return Singleton<BebidaFactory>.instance; }
    }

    public GameObject prefabBebida;
    public float intervaloBebidas = 5f;
    public MergeBebida mergeBebida;

    public List<GameObject> bebidasCreadas = new List<GameObject>();

    void Start()
    {
        StartCoroutine(CreateBebidas());
    }

    public void Create(Vector3 position)
    {
        GameObject bebidaNueva = Instantiate(prefabBebida, transform);
        bebidaNueva.transform.position = position;

        bebidasCreadas.Add(bebidaNueva);
    }

    public void CreateRandom()
    {
        Vector3 randomPosition = Vector3.zero;
        float x = Random.Range(0f, Screen.width);
        float y = Random.Range(0f, Screen.height);
        randomPosition = new Vector3(x, y, 0f);

        Create(randomPosition);
    }

    private IEnumerator CreateBebidas()
    {

        yield return new WaitForSeconds(intervaloBebidas);
        CreateRandom();

 
        while (true)
        {

            yield return new WaitForSeconds(intervaloBebidas);
            if (bebidasCreadas.Count < 20)
            {
                CreateRandom();
            }
        }
    }

    public void CheckAndMergeBebidas()
    {
        List<GameObject> bebidasParaEliminar = new List<GameObject>();

        for (int i = 0; i < bebidasCreadas.Count; i++)
        {
            for (int j = i + 1; j < bebidasCreadas.Count; j++)
            {
                if (mergeBebida.CanMerge(bebidasCreadas[i], bebidasCreadas[j]))
                {
                    mergeBebida.MergeBebidas(bebidasCreadas[i], bebidasCreadas[j]);
                    bebidasParaEliminar.Add(bebidasCreadas[i]);
                    bebidasParaEliminar.Add(bebidasCreadas[j]);
                }
            }
        }

        // Elimina las bebidas fusionadas de la lista
        foreach (var bebida in bebidasParaEliminar)
        {
            bebidasCreadas.Remove(bebida);
            Destroy(bebida);
        }
        if (mergeBebida.nuevaBebidaFusionada != null)
        {
            bebidasCreadas.Add(mergeBebida.nuevaBebidaFusionada);
            mergeBebida.nuevaBebidaFusionada = null;
        }

    }

    void Update()
    {
        CheckAndMergeBebidas();
    }
}
