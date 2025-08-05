using System;


class Radio : IDispositivo
{
    public bool EstaEncendido { get; private set; }

    public void Encender()
    {
        EstaEncendido = false;
        Console.WriteLine("El auto no esta encedido.");
    }
}