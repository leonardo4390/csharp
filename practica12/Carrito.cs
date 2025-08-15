using System;

class Carrito
{
    private List<Producto> productos = new List<Producto>();

    public void AgregarProducto(Producto p)
    {
        productos.Add(p);
    }

    public void MostrarDetalles()
    {
        Console.WriteLine("\nDetalles del Carrito:");
        foreach (var item in productos)
        {
            item.MostrarInfo();
            Console.WriteLine($"Precio final: $ {item.CalcularPrecioFinal()}");
        }
    }

    public double CalcularTotal()
    {
        if (productos.Count == 0)
        {
            Console.WriteLine("No hay productos agregado.");
            return 0;
        }
        else
        {
            return productos.Sum(p => p.CalcularPrecioFinal());
        }
        
    }

    
}