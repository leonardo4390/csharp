using System;

class Gato : Animal
{
    public Gato(string nombre, int edad, string raza) : base(nombre, edad, raza) { }

    public override void EmitirSonido()
    {
        Console.WriteLine("Miauuuuu...");
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Gato: {Nombre} Edad: {Edad} Raza: {Raza}");
    }
}