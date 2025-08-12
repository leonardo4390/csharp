using System;

class HabitacionSuite : Habitacion
{
    public double CargoVip{ get; private set; }
    public HabitacionSuite(int numero, double precioPorNoche, double cargoVip) : base(numero, precioPorNoche)
    {
        CargoVip = cargoVip;
    }

    public override double CalcularPrecio(int dias)
    {
        return (PrecioPorNoche + CargoVip) * dias;
    }
}