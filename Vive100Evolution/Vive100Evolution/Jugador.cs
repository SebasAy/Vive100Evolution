using System;
using System.Collections.Generic;

public class Jugador
{
    public int Monedas { get; set; }
    public List<Bebida> InventarioBebidas { get; private set; }
    public Tienda Tienda { get; private set; }
    public int LimiteBebidasEnPantalla { get; private set; }
    public int TiempoAparicionBebida { get; private set; }
    public int MultiplicadorDinero { get; private set; }

    public Jugador()
    {
        Monedas = 0;
        InventarioBebidas = new List<Bebida>();
        Tienda = new Tienda();
        LimiteBebidasEnPantalla = 5;
        TiempoAparicionBebida = 10;
        MultiplicadorDinero = 1;
    }

    public void ComprarMejora(string tipoMejora)
    {
        // Lógica para comprar mejoras en la tienda y aplicarlas al jugador
        Mejora mejora = Tienda.ObtenerMejoraPorTipo(tipoMejora);

        if (mejora != null && Monedas >= mejora.Precio)
        {
            Monedas -= mejora.Precio;

            switch (tipoMejora)
            {
                case "TiempoGeneracion":
                    TiempoAparicionBebida -= 1;
                    break;
                case "MultiplicadorDinero":
                    MultiplicadorDinero += 1;
                    break;
            }
        }
    }

    public void GanarMonedasPorNivelBebida(int nivel)
    {
        // Lógica para ganar monedas cuando una bebida alcanza un nivel específico
        int ganancia = nivel * MultiplicadorDinero;
        Monedas += ganancia;
    }

    public void GenerarBebida()
    {
        // Lógica para generar una nueva bebida en el inventario
        Bebida nuevaBebida = new Bebida(1); // Nueva bebida de nivel 1
        InventarioBebidas.Add(nuevaBebida);
    }
}