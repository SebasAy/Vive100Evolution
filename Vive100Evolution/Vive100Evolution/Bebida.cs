using System;

public class Bebida
{
    public int Nivel { get; private set; }
    public int TiempoParaGenerar { get; private set; }
    public int ValorMoneda { get; private set; }

    public Bebida(int nivel)
    {
        Nivel = nivel;
        TiempoParaGenerar = CalcularTiempoGeneracion();
        ValorMoneda = CalcularValorMoneda();
    }

    public Bebida CombinarCon(Bebida otraBebida)
    {
        if (this.Nivel == otraBebida.Nivel)
        {
            int nuevoNivel = this.Nivel + 1;
            return new Bebida(nuevoNivel);
        }
        else
        {
            // No se pueden combinar bebidas de diferentes niveles
            return null;
        }
    }

    private int CalcularTiempoGeneracion()
    {
        // Calcula el tiempo de generación basado en el nivel de la bebida
        return 10 - Nivel; // Ejemplo: Tiempo decreciente a medida que aumenta el nivel
    }

    private int CalcularValorMoneda()
    {
        // Calcula el valor de moneda basado en el nivel de la bebida
        return Nivel * 2; // Ejemplo: Valor aumentando a medida que aumenta el nivel
    }
}