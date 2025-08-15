using System;

abstract class Producto
{
    public string Nombre { get; private set; }
    public double Precio { get; private set; }

    public Producto(string nombre, double precio)
    {
        Nombre = nombre;
        Precio = precio;
    }

    public abstract double CalcularPrecioFinal();

    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Producto: {Nombre} - Precio: {Precio}");
    }
}