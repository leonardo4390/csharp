using System;
/*
    EJERCICIO 1: Sistema de Gestión de Animales en un Refugio
    Enunciado
    Crea un sistema de gestión de animales para un refugio.

    Crea una clase abstracta Animal con:

    Propiedades: Nombre, Edad, Raza

    Método abstracto: EmitirSonido()

    Método virtual: MostrarInfo() (se podrá sobrescribir)

    Crea clases derivadas:

    Perro y Gato, que heredan de Animal

    Implementan EmitirSonido() y sobrescriben MostrarInfo()

    Usa encapsulamiento en las propiedades (con get y set validados).

    Crea una clase Refugio que:

    Tenga una lista de Animal

    Métodos: AgregarAnimal, MostrarAnimales, BuscarPorNombre
*/
class Program
{
    public static void Main(String[] args)
    {
        Refugio refugio = new Refugio();

        refugio.AgregarAnimal(new Perro("max", 3, "pitbul"));
        refugio.AgregarAnimal(new Gato("rupe", 4, "siames"));

        Console.WriteLine("Animales en el refugio:");
        refugio.MostrarAnimales();

        var buscar = refugio.BuscarPorNombre("rupe");
        if (buscar != null)
        {
            Console.WriteLine("\nAnimal encontrado");
            buscar.MostrarInfo();
        }
    }

    
}

