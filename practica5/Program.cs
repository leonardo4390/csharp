/*Abstraccion*/
using System;
using System.Runtime.InteropServices;
// clases abstractas
// abstract class Animal
// {
//     public abstract void HacerSonido();

//     public void Dormir()
//     {
//         Console.WriteLine("Zzzz...");
//     }

// }

// class Perro : Animal
// {
//     public override void HacerSonido()
//     {
//         Console.WriteLine("Guau guau");
//     }
// }

/*interfaces*/
class Program
{

    // public static void Main(String[] args)
    // {
    //     Animal animal = new Perro();
    //     animal.HacerSonido();
    //     animal.Dormir();
    // }
    // interface Ivehiculo
    // {
    //     void Conducir();
    //     int velocidadMaxima{ get; }
    // }

    // class Auto : Ivehiculo
    // {
    //     public int velocidadMaxima => 100;

    //     public void Conducir()
    //     {
    //         Console.WriteLine("Conduciendo el auto...");
    //     }
    // }
    // public static void Main(String[] args)
    // {
    //     Ivehiculo vehiculo = new Auto();
    //     vehiculo.Conducir();
    //     Console.WriteLine(vehiculo.velocidadMaxima);
    // }

    /*
        Ejercicio 1: Zoológico con clases abstractas
    Objetivo: Aplicar clases abstractas con métodos abstractos y comunes.

    Enunciado:
    Crea una clase abstracta Animal con:

    Un método abstracto HacerSonido()

    Un método concreto Dormir() que imprima "El animal está durmiendo..."

    Crea dos clases concretas: Leon y Elefante que extiendan Animal, y cada uno implemente HacerSonido().

    En Main, crea una lista de Animal, agrega un león y un elefante, y recorre la lista llamando a ambos métodos.
    */
    public static void Main(String[] args)
    {
        List<Animal> animals = new List<Animal>();
        Animal animal = new Leon();
        Animal animal1 = new Elefante();

        animals.Add(animal);
        animals.Add(animal1);

        foreach (var item in animals)
        {
            item.HacerSonido();
            item.Dormir();
            Console.WriteLine();
        }
        
    }
}
