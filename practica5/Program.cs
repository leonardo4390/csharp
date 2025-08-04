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
    interface Ivehiculo
    {
        void Conducir();
        int velocidadMaxima{ get; }
    }

    class Auto : Ivehiculo
    {
        public int velocidadMaxima => 100;

        public void Conducir()
        {
            Console.WriteLine("Conduciendo el auto...");
        }
    }
    public static void Main(String[] args)
    {
        Ivehiculo vehiculo = new Auto();
        vehiculo.Conducir();
        Console.WriteLine(vehiculo.velocidadMaxima);
    }
}
