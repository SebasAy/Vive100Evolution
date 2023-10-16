using System;
using System.Collections.Generic;

public class Tienda
{
    private List<Mejora> mejorasDisponibles;

    public Tienda()
    {
        mejorasDisponibles = new List<Mejora>();
        // Agrega algunas mejoras disponibles al inicio del juego
        mejorasDisponibles.Add(new Mejora("TiempoGeneracion", 10, 100));
        mejorasDisponibles.Add(new Mejora("MultiplicadorDinero", 5, 200));
        mejorasDisponibles.Add(new Mejora("LimiteBebidas", 2, 150));
    }

    public void AgregarMejora(Mejora mejora)
    {
        mejorasDisponibles.Add(mejora);
    }

    public Mejora ObtenerMejoraPorTipo(string tipoMejora)
    {
        return mejorasDisponibles.Find(m => m.Tipo == tipoMejora);
    }

    public List<Mejora> ObtenerMejorasDisponibles()
    {
        return mejorasDisponibles;
    }

    public bool ComprarMejora(Jugador jugador, Mejora mejora)
    {
        if (jugador.Monedas >= mejora.Precio)
        {
            jugador.Monedas -= mejora.Precio;
            return true; // La compra fue exitosa
        }
        else
        {
            return false; // El jugador no tiene suficientes monedas para comprar la mejora
        }
    }
}