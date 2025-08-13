/*
    Sistema de empleados con cálculo de sueldo
Objetivo: Crear una clase abstracta Empleado con un método calcular_sueldo(). Heredan EmpleadoFijo y EmpleadoPorHora.
- EmpleadoFijo: tiene sueldo base + bonificación.
- EmpleadoPorHora: cobra por horas trabajadas.
Desafíos:
- Usar atributos privados.
- Mostrar resumen de empleados y total de sueldos.

    */

using System;

class Program
{
    public static void Main(String[] args)
    {
        List<Empleado> empleados = new List<Empleado>();

        AgregarEmpleadoFijo(empleados);
        AgregarEmpleadoPorHora(empleados);

        Console.WriteLine("\nEmpleados:");

        foreach (var item in empleados)
        {
            item.MostrarInfo();
            Console.WriteLine($"Sueldo: {item.CalcularSueldo():C}");
            Console.WriteLine();
        }

    }

    public static void AgregarEmpleadoFijo(List<Empleado> empleados)
    {
        while (true)
        {
            Console.WriteLine("Ingrese el nombre del empleado: ");
            var nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el dni del empleado: ");
            int dni = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo base del empleado: ");
            double sueldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese bonificacion del empleado: ");
            double bonificacion = Convert.ToDouble(Console.ReadLine());

            EmpleadoFijo empleado = new EmpleadoFijo(nombre, dni, sueldo, bonificacion);
            empleados.Add(empleado);

            Console.WriteLine("Desea Ingresar otro Empleado?(s/n): ");
            var agregar = Console.ReadLine();

            if (agregar != "s")
            {
                break;
            }

        }
    }

    public static void AgregarEmpleadoPorHora(List<Empleado> empleados)
    {
        while (true)
        {
            Console.WriteLine("Ingrese el nombre del empleado: ");
            var nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el dni del empleado: ");
            int dni = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el pago por hora: ");
            double pagoPorHora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese las horas trabajadas: ");
            int horas = Convert.ToInt32(Console.ReadLine());

            EmpleadoPorHora empleadoPorHora = new EmpleadoPorHora(nombre, dni, pagoPorHora, horas);
            empleados.Add(empleadoPorHora);

            Console.WriteLine("Desea Ingresar otro Empleado?(s/n): ");
            var agregar = Console.ReadLine();

            if (agregar != "s")
            {
                break;
            }

        }
    }
}