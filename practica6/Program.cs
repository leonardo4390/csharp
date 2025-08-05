using System;


class Program
{
    /*
         1: Vehículos
    Enunciado:
    Crear una clase base Vehiculo con propiedades como Marca, Modelo, y métodos como Arrancar() y Detener().

    Crear clases derivadas:

    Auto con una propiedad CantidadPuertas y un método TocarBocina().

    Moto con una propiedad TipoCasco y un método HacerWheelie().

     Objetivo:
    Practicar herencia básica, propiedades y métodos únicos por tipo.
    */

    public static void Main(String[] args)
    {
        Auto auto = new Auto("Toyota", "Corolla", 4);
        Moto moto = new Moto("Yamaha", "R1", "integral");
        auto.Arrancar();
        auto.TocarBocina();
        auto.Detener();
        
        Console.WriteLine();

        moto.Arrancar();
        moto.HacerWheelie();
        moto.Detener();
        Console.WriteLine();
    }
}