using System;

class ProductoConDescuento : Producto
{
    public int Descuento { get; private set; }

    public ProductoConDescuento(string nombre, double precio, int descuento) : base(nombre, precio)
    {
        Descuento = descuento;
    }

    public override double CalcularPrecioFinal()
    {
        return Precio - (Precio * Descuento/100);
    }
}