using System;

/*
    Ejercicio 1: Sistema de Reservas de Hotel
Enunciado:
Diseñar un sistema para gestionar las reservas en un hotel.
Debe cumplir con lo siguiente:

Clase abstracta Habitacion con:

Propiedades: Numero, PrecioPorNoche.

Método abstracto CalcularPrecio(int dias).

Método virtual Descripcion().

Clases derivadas:

HabitacionSimple (precio por noche fijo).

HabitacionSuite (precio por noche + cargo adicional por servicio VIP).

Clase Cliente con:

Encapsulación en Nombre y Dni.

Constructor sobrecargado para crear cliente con solo nombre o con nombre y dni.

En Main, crear varias habitaciones y clientes, reservar para diferentes días y
 mostrar el costo total y la descripción.
*/

class Program
{
    public static void Main(String[] args)
    {
        Cliente c1 = new Cliente("Franco", 2345);
        Cliente c2 = new Cliente("leonardo", 234521);

        Habitacion h1 = new HabitacionSimple(10, 50000);
        Habitacion h2 = new HabitacionSuite(24, 70000, 12000);

        Console.WriteLine($"{c1.Nombre} reservo: {h1.Descripcion()} - Total: {h1.CalcularPrecio(2):C}");
        Console.WriteLine($"{c2.Nombre} reservo: {h2.Descripcion()} - Total: {h2.CalcularPrecio(3):C}");
    }
}