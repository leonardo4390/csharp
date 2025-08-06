using System;


class Program
{
    /*
         1: Vehículos
    Enunciado:
    Crear una clase base Vehiculo con propiedades como Marca, Modelo, y métodos como Arrancar() y Detener().

    Crear clases derivadas:

    Auto con una propiedad CantidadPuertas y un método TocarBocina().

    Moto con una propiedad TipoCasco y un método HacerWheelie().

     Objetivo:
    Practicar herencia básica, propiedades y métodos únicos por tipo.
    */

    // public static void Main(String[] args)
    // {
    //     Auto auto = new Auto("Toyota", "Corolla", 4);
    //     Moto moto = new Moto("Yamaha", "R1", "integral");
    //     auto.Arrancar();
    //     auto.TocarBocina();
    //     auto.Detener();

    //     Console.WriteLine();

    //     moto.Arrancar();
    //     moto.HacerWheelie();
    //     moto.Detener();
    //     Console.WriteLine();
    // }

    /*
        Ejercicio 2: Empleados
    Enunciado:
    Crear una clase Empleado con propiedades:

    Nombre

    SueldoBase

    Método CalcularSueldo()

    Crear clases derivadas:

    EmpleadoTiempoCompleto: suma un bono al sueldo.

    EmpleadoMedioTiempo: sueldo base * 0.5

    Instanciar varios empleados y mostrar sus sueldos usando CalcularSueldo().

    Objetivo:
    Usar herencia + lógica condicional.
    */

    public static void Main(String[] args)
    {
        List<Empleado> empleadoTiempoCompletos = new List<Empleado>
        {
            new EmpleadoTiempoCompleto("franco",500000,10000),
            new EmpleadoTiempoCompleto("leonardo",600000,11000),
            new EmpleadoTiempoCompleto("jose",550000,12000)
        };

        List<Empleado> empleadoMedioTiempos = new List<Empleado>
        {
            new EmpleadoMedioTiempo("belen", 500000),
            new EmpleadoMedioTiempo("belen", 600000)
        };

        Console.WriteLine("Empleado tiempo completo.");
        MostrarEmpleado(empleadoTiempoCompletos);
        Console.WriteLine("\nEmpleado medio tiempo.");
        MostrarEmpleado(empleadoMedioTiempos);



    }

    public static void MostrarEmpleado(List<Empleado> empleado)
    {
        foreach (var item in empleado)
        {
            Console.WriteLine($"Nombre: {item.Nombre} \nsueldo base: {item.SueldoBase} \nsueldo total: {item.CalcularSueldo()}");
            Console.WriteLine();
        }
    }
}