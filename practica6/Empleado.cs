using System;


class Empleado
{
    public string Nombre { get; set; }
    public double SueldoBase { get; set; }

    public Empleado(string nombre, double sueldoBase)
    {
        Nombre = nombre;
        SueldoBase = sueldoBase;
    }

    public virtual double CalcularSueldo()
    {
        return SueldoBase;
    }
}