using System;


class ProductoConIVA : Producto
{
    private double Iva = 0.21;

    public ProductoConIVA(string nombre, double precio):base(nombre, precio){}

    public override double CalcularPrecioFinal()
    {
        return Precio + (Iva * Precio);
    }
}