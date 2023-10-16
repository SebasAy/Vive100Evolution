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
    public int contadorBebidas = 0;
    public float intervaloBebidas = 5f;

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
        randomPosition = Camera.main.WorldToViewportPoint(randomPosition);

        Create(randomPosition);
    }

    private IEnumerator CreateBebidas()
    {

        yield return new WaitForSeconds(intervaloBebidas);
        CreateRandom();

 
        while (true)
        {

            yield return new WaitForSeconds(intervaloBebidas);
            if (contadorBebidas < 20)
            {
                // Creamos una bebida
                CreateRandom();
            }
        }
    }
}
