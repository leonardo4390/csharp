using System;


class Perro : Animal
{
    public Perro(string nombre, int edad, string raza) : base(nombre, edad, raza) { }

    public override void EmitirSonido()
    {
        Console.WriteLine("Guau Guau");
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Perro: {Nombre} Edad: {Edad} Raza: {Raza}");
    }
}