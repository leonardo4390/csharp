using System;


class EmpleadoMedioTiempo : Empleado
{
    public EmpleadoMedioTiempo(string nombre, double sueldoBase) : base(nombre, sueldoBase) { }

    public override double CalcularSueldo()
    {
        return SueldoBase * 0.5;
    }
}