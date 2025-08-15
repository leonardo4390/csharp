using System;


class ProductoConIva : Producto
{
    private double _IVA = 0.21;

    public ProductoConIva(string nombre, double precio) : base(nombre, precio) { }

    public override double CalcularPrecioFinal()
    {
        return Precio + (Precio * _IVA);
    }
}