using System;

class HabitacionSimple : Habitacion
{
    public HabitacionSimple(int numero, double precioPorNoche) : base(numero, precioPorNoche) { }

    public override double CalcularPrecio(int dias)
    {
        return PrecioPorNoche * dias;
    }
}