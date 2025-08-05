using System;

class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }
    public void Arrancar()
    {
        Console.WriteLine($"{Marca} {Modelo} ha arrancado.");
    }

    public void Detener()
    {
        Console.WriteLine($"{Marca} {Modelo} se ha detenido.");
    }
}