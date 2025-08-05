using System;

class Televisor : IDispositivo
{
    public bool EstaEncendido{ get; private set; }

    public void Encender()
    {
        EstaEncendido = true;
        Console.WriteLine("Esta encendido.");
    }
}