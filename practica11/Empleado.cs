using System;

abstract class Empleado
{
    private string Nombre;
    private int Dni;


    public string GetNombre
    {
        get { return Nombre; }
        set{ Nombre = value; }
    }

    public int GetDni
    {
        get { return Dni; }
        set{ Dni = value; }
    }
    public Empleado(string nombre, int dni)
    {
        Nombre = nombre;
        Dni = dni;
    }
    public abstract double CalcularSueldo();

    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre} -  Dni: {Dni}");
    }
}