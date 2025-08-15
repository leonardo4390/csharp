using System;

/*
    Carrito de compras con productos variados
Objetivo: Crear una clase Producto con método calcular_precio_final(). Heredan ProductoConIva, ProductoConDescuento, y ProductoImportado (con recargo adicional).
- Clase Carrito: permite agregar productos, mostrar el detalle y calcular el total.
Desafíos:
- Aplicar polimorfismo para calcular precios.
- Usar listas privadas y métodos bien encapsulados.

*/

class Program
{
    public static void Main(String[] args)
    {
        Carrito carrito = new Carrito();

        AgregarProductoConIva(carrito);
        AgregarProductoConDescuento(carrito);
        AgregarProductoImportado(carrito);
        carrito.MostrarDetalles();

        Console.WriteLine($"Total a Pagar: $ {carrito.CalcularTotal()}");
    }

    public static void AgregarProductoConIva(Carrito carrito)
    {
        Console.WriteLine("\nProductos con Iva:");
        while (true)
        {
            Console.WriteLine("Ingresa el nombre del producto: ");
            var producto = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());
            carrito.AgregarProducto(new ProductoConIva(producto, precio));

            Console.WriteLine("Desea ingresar otro producto? (s/n): ");
            var agregar = Console.ReadLine();
            if (agregar != "s")
            {
                break;
            }
        }
    }

    public static void AgregarProductoConDescuento(Carrito carrito)
    {
        Console.WriteLine("\nProductos con Descuento:");
        while (true)
        {
            Console.WriteLine("Ingresa el nombre del producto: ");
            var producto = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());
            carrito.AgregarProducto(new ProductoConDescuento(producto, precio, 15));

            Console.WriteLine("Desea ingresar otro producto? (s/n): ");
            var agregar = Console.ReadLine();
            if (agregar != "s")
            {
                break;
            }
        }
    }
    
    public static void AgregarProductoImportado(Carrito carrito)
    {
        Console.WriteLine("\nProductos con Recargo:");
        while (true)
        {
            Console.WriteLine("Ingresa el nombre del producto: ");
            var producto = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());
            carrito.AgregarProducto(new ProductoImportado(producto, precio, 20));

            Console.WriteLine("Desea ingresar otro producto? (s/n): ");
            var agregar = Console.ReadLine();
            if (agregar != "s")
            {
                break;
            }
        }
    }
}
