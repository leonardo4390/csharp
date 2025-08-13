using System;

class EmpleadoFijo : Empleado
{
    private double SueldoBase;
    private double Bonificacion;

    public double GetSueldoBase
    {
        get { return SueldoBase; }
        set{ SueldoBase = value; }
    }

    public double GetBonificacion
    {
        get { return Bonificacion; }
        set{ Bonificacion = value; }
    }
    public EmpleadoFijo(string nombre, int dni, double sueldoBase, double bonificacion) : base(nombre, dni)
    {
        SueldoBase = sueldoBase;
        Bonificacion = bonificacion;
    }

    public override double CalcularSueldo()
    {
        return SueldoBase + Bonificacion;
    }
}