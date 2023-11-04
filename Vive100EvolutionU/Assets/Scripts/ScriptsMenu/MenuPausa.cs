using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{

    [SerializeField] private GameObject botonPausa;

    [SerializeField] private GameObject menuPausa;

    [SerializeField] private GameObject menuoOpciones;

    [SerializeField] private GameObject botonTienda;

    [SerializeField] private GameObject menuTienda;



    public void Pausa()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
        menuoOpciones.SetActive(false);
        botonTienda.SetActive(false);
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
        menuoOpciones.SetActive(false);
        botonTienda.SetActive(true);
        menuTienda.SetActive(false);

    }

    public void Opciones()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(false);
        menuoOpciones.SetActive(true);
        botonTienda.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);

    }

    public void Tienda()
    {
        botonPausa.SetActive(false);
        botonTienda.SetActive(false);
        menuTienda.SetActive(true);
    }


}
