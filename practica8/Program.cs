using System;


class Program
{
    /*
        EJERCICIO 2: Sistema de Facturación con Productos y Clientes
    Enunciado
    Crea una clase base Producto con:

    Propiedades: Nombre, Precio

    Método virtual CalcularPrecioFinal()

    Crea subclases:

    ProductoConIVA (aplica 21% de IVA)

    ProductoConDescuento (aplica un % de descuento)

    Usa sobrecarga de constructores para manejar inicializaciones.

    Crea una clase Factura:

    Lista de productos

    Método AgregarProducto()

    Método MostrarFactura() que calcule el total
    */

    public static void Main(String[] args)
    {
        Factura factura = new Factura();

        factura.AgregarProducto(new Producto("banana", 3000));
        factura.AgregarProducto(new ProductoConIVA("frutilla", 1500));
        factura.AgregarProducto(new ProductoConDescuento("manzana", 2500, 15));

        factura.MostrarFactura();
    }
}
