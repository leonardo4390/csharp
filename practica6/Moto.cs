using System;

class Moto : Vehiculo
{
    public string TipoCasco { get; set; }

    public Moto(string marca, string modelo, string tipoCasco) : base(marca, modelo)
    {
        TipoCasco = tipoCasco;

    }
    public void HacerWheelie()
    {
        Console.WriteLine("Moto hace una Wheelie.");
    }
}