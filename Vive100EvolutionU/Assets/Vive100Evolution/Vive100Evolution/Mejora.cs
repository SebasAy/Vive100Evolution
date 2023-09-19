using System;

public class Mejora
{
    public string Tipo { get; private set; }
    public int Nivel { get; private set; }
    public int Precio { get; private set; }

    public Mejora(string tipo, int nivel, int precio)
    {
        Tipo = tipo;
        Nivel = nivel;
        Precio = precio;
    }
}