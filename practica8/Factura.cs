using System;

class Factura
{
    List<Producto> productos = new List<Producto>();

    public void AgregarProducto(Producto producto)
    {
        productos.Add(producto);
    }

    public void MostrarFactura()
    {
        double total = 0;
        Console.WriteLine("\nFactura:");

        foreach (var item in productos)
        {
            Console.WriteLine(item.ToString());
            total += item.CalcularPrecioFinal();
        }
        Console.WriteLine($"Total: ${total}");
    }
    
}