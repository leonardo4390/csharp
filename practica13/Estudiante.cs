using System;

abstract class Estudiante
{
    public string Nombre { get; private set; }
    public int Dni { get; private set; }

    public Estudiante(string nombre, int dni)
    {
        Nombre = nombre;
        Dni = dni;
    }

    public abstract double CalcularPromedio();

    public virtual void MostrarInfo()
    {
        double promedio = CalcularPromedio();
        string estado = promedio >= 6 ? "Aprobado" : "Reprobado";
        Console.WriteLine($"Nombre: {Nombre} -  Dni: {Dni} - Promedio: {promedio} - Estado: {estado}");
        
    }
}