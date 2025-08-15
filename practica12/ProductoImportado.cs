using System;

class ProductoImportado : Producto
{
    public int Recargo { get; private set; }

    public ProductoImportado(string nombre, double precio, int recargo) : base(nombre, precio)
    {
        Recargo = recargo;
    }

    public override double CalcularPrecioFinal()
    {
        return Precio + (Precio * Recargo/100);
    }
}