using System;

class Producto
{
    public string Nombre { get; private set; }
    public double Precio { get; private set; }

    public Producto(string nombre, double precio)
    {
        Nombre = nombre;
        Precio = precio;
    }

    public virtual double CalcularPrecioFinal()
    {
        return Precio;
    }

    public override string ToString()
    {
        return $"{Nombre}: ${CalcularPrecioFinal(): 0.00}";
    }
}