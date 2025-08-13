using System;

class EmpleadoPorHora : Empleado
{
    public double ValorHora { get; private set; }
    public int HorasTrabajadas { get; private set; }

    public EmpleadoPorHora(string nombre, int dni, double valorHora, int horasTrabajadas) : base(nombre, dni)
    {
        ValorHora = valorHora;
        HorasTrabajadas = horasTrabajadas;
    }

    public override double CalcularSueldo()
    {
        return ValorHora * HorasTrabajadas;
    }
}