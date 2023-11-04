using System;
using System.Collections.Generic;

public class Jugador
{
    public int Monedas { get; set; }
    public List<Bebida> InventarioBebidas { get; set; }
    public Tienda Tienda { get; set; }
    public int LimiteBebidasEnPantalla { get; set; }
    public int TiempoAparicionBebida { get; set; }
    public int MultiplicadorDinero { get; set; }

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
        int ganancia = nivel * MultiplicadorDinero;
        Monedas += ganancia;
    }
}