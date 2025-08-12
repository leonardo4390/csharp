using System;

class Cliente
{

    public string Nombre { get; private set; }
    public int Dni { get; private set; }

    public Cliente(string nombre, int dni)
    {
        Nombre = nombre;
        Dni = dni;
    }

    
}