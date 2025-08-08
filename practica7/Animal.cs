using System;

abstract class Animal
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Raza { get; set; }

    public Animal(string nombre, int edad, string raza)
    {
        Nombre = nombre;
        Edad = edad;
        Raza = raza;
    }

    public abstract void EmitirSonido();

    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre} Edad: {Edad} Raza: {Raza}");
    }
}