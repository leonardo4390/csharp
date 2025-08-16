using System;
using System.Data;

/*
     Sistema de estudiantes y evaluaciones
Objetivo: Clase abstracta Estudiante con método calcular_promedio(). Heredan EstudianteSecundaria y EstudianteUniversitario.
- EstudianteSecundaria: promedio de 3 materias.
- EstudianteUniversitario: promedio ponderado con créditos.
Desafíos:
- Implementar lógica de cálculo distinta según tipo.
- Mostrar lista de estudiantes con su promedio y estado (aprobado/reprobado).

*/
class Program
{
    public static void Main(String[] args)
    {
        List<Estudiante> estudiantes = new List<Estudiante>();

        AgregarEstudiantesSecundario(estudiantes);
        AgregarEstudiantesUniversitario(estudiantes);
        MostrarEstudiantes(estudiantes);

    }

    public static void AgregarEstudiantesSecundario(List<Estudiante> estudiantes)
    {
        Console.WriteLine("\nEstudiantes secundarios:");
        while (true)
        {
            Console.WriteLine("Ingrese el nombre del estudiante: ");
            var nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el dni del estudiante: ");
            int dni = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 1 del estudiante: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 2 del estudiante: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 3 del estudiante: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            EstudianteSecundaria estudianteSecundaria = new EstudianteSecundaria(nombre, dni, nota1, nota2, nota3);
            estudiantes.Add(estudianteSecundaria);
            Console.WriteLine("Desea agregar otro estudiante? (s/n): ");
            var agregar = Console.ReadLine();

            if (agregar != "s")
            {
                break;
            }
        }
    }

    public static void AgregarEstudiantesUniversitario(List<Estudiante> estudiantes)
    {
        Console.WriteLine("\nEstudiantes Universitarios:");
        while (true)
        {
            Console.WriteLine("Ingrese el nombre del estudiante: ");
            var nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el dni del estudiante: ");
            int dni = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 1 del estudiante: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el credito de la materia: ");
            int credito1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 2 del estudiante: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el credito de la materia 2: ");
            int credito2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 3 del estudiante: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el credito de la materia 3: ");
            int credito3 = Convert.ToInt32(Console.ReadLine());

            EstudianteUniversitario estudianteUniversitario = new EstudianteUniversitario(nombre, dni);
            estudianteUniversitario.AgregarMaterias(nota1, credito1);
            estudianteUniversitario.AgregarMaterias(nota2, credito2);
            estudianteUniversitario.AgregarMaterias(nota3, credito3);
            estudiantes.Add(estudianteUniversitario);
            Console.WriteLine("Desea agregar otro estudiante? (s/n): ");
            var agregar = Console.ReadLine();

            if (agregar != "s")
            {
                break;
            }
        }
    }

    public static void MostrarEstudiantes(List<Estudiante> estudiantes)
    {
        Console.WriteLine("\nDetalles de los estudiantes:");
        foreach (var item in estudiantes)
        {
            item.MostrarInfo();
        }
    }
}