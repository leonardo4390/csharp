using System;

abstract class Habitacion
{
    public int Numero { get; private set; }
    public double PrecioPorNoche { get; private set; }

    public Habitacion(int numero, double precioPorNoche)
    {
        Numero = numero;
        PrecioPorNoche = precioPorNoche;
    }

    public abstract double CalcularPrecio(int dias);

    public virtual string Descripcion()
    {
        return $"Habitacion N°: {Numero} | Precio base: {PrecioPorNoche}";
    }
}