using System;


class Auto : Vehiculo
{
    public int CantidadPuertas { get; set; }

    public Auto(string marca, string modelo, int cantidadPuerta):base(marca,modelo)
    {
        CantidadPuertas = cantidadPuerta;
    }

    public void TocarBocina()
    {
        Console.WriteLine($"Auto Piiiiip....");
    }
}