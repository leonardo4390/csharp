using System;


class ProductoConDescuento : Producto
{
    public double PorcentajeDescuento { get; private set; }

    public ProductoConDescuento(string nombre, double precio, double porcentajeDescuento) : base(nombre, precio)
    {
        PorcentajeDescuento = porcentajeDescuento;
    }

    public override double CalcularPrecioFinal()
    {
        return Precio - (Precio * PorcentajeDescuento / 100);
    }
}