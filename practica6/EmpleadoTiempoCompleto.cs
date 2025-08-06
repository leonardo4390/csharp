using System;

class EmpleadoTiempoCompleto : Empleado
{
    public double Bono { get; set; }

    public EmpleadoTiempoCompleto(string nombre, double sueldoBase, double bono) : base(nombre, sueldoBase)
    {
        Bono = bono;
    }

    public override double CalcularSueldo()
    {
        return SueldoBase + Bono;
    }
}