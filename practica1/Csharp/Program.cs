using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Principal;


class Program
{
    /*Objetivo: Registrar gastos y calcular el total.
Descripción: Pedir al usuario que ingrese varios gastos 
con descripción y monto. Al finalizar, mostrar cada gasto 
y la suma total.
Extras opcionales: Filtrar gastos mayores a cierto monto.*/

    // public static void Main(String[] args)
    // {
    //     List<Gastos> gastos = new List<Gastos>();
    //     int id = 0;

    //     while (true)
    //     {
    //         id++;
    //         Console.WriteLine("\nIngrese descripcion del gasto: ");
    //         var descrip = Console.ReadLine();
    //         Console.WriteLine("Ingrese el monto del gasto: ");
    //         int monto = Convert.ToInt32(Console.ReadLine());
    //         Gastos nuevoGasto = new Gastos { ID = id, Descripción = descrip, Monto = monto };
    //         gastos.Add(nuevoGasto);
    //         Console.WriteLine("Desea Ingresar algun otro gasto? (s/n): ");
    //         var respuesta = Console.ReadLine();
    //         if (respuesta != "s")
    //         {
    //             break;
    //         }
    //     }
    //     MostrarGastos(gastos);
    //     GastoTotal(gastos);
    //     GastosMayores(gastos);


    // }

    // public static void MostrarGastos(List<Gastos> gastos)
    // {
    //     Console.WriteLine("\nMostrar Gastos:");
    //     foreach (Gastos item in gastos)
    //     {
    //         Console.WriteLine($"ID = {item.ID} | Descripcion = {item.Descripción} | Monto = ${item.Monto}");
    //     }
    // }

    // public static void GastoTotal(List<Gastos> gastos)
    // {
    //     int suma = 0;

    //     foreach (Gastos item in gastos)
    //     {
    //         suma += item.Monto;
    //     }
    //     Console.WriteLine($"Gasto Total = ${suma}");
    // }

    // public static void GastosMayores(List<Gastos> gasto)
    // {
    //     Console.WriteLine("\nGastos mayores a $5000");
    //     foreach (Gastos item in gasto)
    //     {
    //         if (item.Monto > 5000)
    //         {
    //             Console.WriteLine($"ID = {item.ID} | Descripcion = {item.Descripción} | Monto = ${item.Monto}");
    //         }
    //     }
    // }
    /*Objetivo: Crear una lista de estudiantes con sus 
    respectivas notas.
Descripción: Por cada estudiante, registrar nombre y una 
lista de 3 notas. Mostrar promedio de cada estudiante y el 
promedio general.
Extras opcionales: Determinar quién aprobó (promedio ≥ 6).*/

    // public static void Main(String[] args)
    // {
    //     List<Estudiantes> estudiantes = new List<Estudiantes>();


    //     while (true)
    //     {
    //         Console.WriteLine("\nIngrese el nombre del estudiante: ");
    //         var alumno = Console.ReadLine();
    //         Console.WriteLine("Ingrese la nota 1: ");
    //         float nota1 = Convert.ToSingle(Console.ReadLine());
    //         Console.WriteLine("Ingrese la nota 2: ");
    //         float nota2 = Convert.ToSingle(Console.ReadLine());
    //         Console.WriteLine("Ingrese la nota 3: ");
    //         float nota3 = Convert.ToSingle(Console.ReadLine());
    //         List<float> notas = new List<float> { nota1, nota2, nota3 };
    //         Estudiantes nuevoEstudiante = new Estudiantes { Nombre = alumno, Notas = notas };
    //         estudiantes.Add(nuevoEstudiante);
    //         Console.WriteLine("Desea ingresar notas de otro alumno? (s/n)");
    //         var respuesta = Console.ReadLine();
    //         if (respuesta != "s")
    //         {
    //             break;
    //         }
    //     }
    //     MostrarAlumno(estudiantes);
    // }

    // public static void MostrarAlumno(List<Estudiantes> estudiantes)
    // {
    //     Console.WriteLine("\nEstados de los alumnos");
    //     foreach (Estudiantes item in estudiantes)
    //     {
    //         Console.Write($"Alumno: {item.Nombre} | Notas: {item.Notas[0]}, {item.Notas[1]}, {item.Notas[2]}");
    //         float promedio = (item.Notas[0] + item.Notas[1] + item.Notas[2]) / 3;
    //         Console.WriteLine($"\nPromedio: {promedio}");
    //         if (promedio >= 6)
    //         {
    //             Console.WriteLine("Estado: Aprobado");
    //         }
    //         else
    //         {
    //             Console.WriteLine("Estado: Desaprobado");
    //         }
    //     }
    // }
    /*Objetivo: Armar un sistema básico de inventario.
Descripción: Registrar productos con nombre, código y 
stock actual. Luego permitir buscar un producto por código 
y mostrar sus datos.
Extras opcionales: Permitir actualización de stock.
*/
    public static void Main(String[] args)
    {
        List<Inventario> inventarios = new List<Inventario>();
        int codigo = 0;

        while (true)
        {
            codigo += 1;
            Console.WriteLine("Ingrese el nombre del producto: ");
            string producto = Console.ReadLine();
            Console.WriteLine("Ingrese el stock del producto: ");
            int stock = Convert.ToInt32(Console.ReadLine());
            Inventario nuevoProducto = new Inventario { Codigo = codigo, Producto = producto, Stock = stock };
            inventarios.Add(nuevoProducto);
            Console.WriteLine("Desea ingresar otro producto? (s/n): ");
            var seguir = Console.ReadLine();
            if (seguir != "s")
            {
                break;
            }
        }
        Console.WriteLine("\nInventario:");
        MostrarInventario(inventarios);
        Console.WriteLine("\nIngrese el codigo del producto a buscar: ");
        int buscar = Convert.ToInt32(Console.ReadLine());
        BuscarProducto(inventarios, buscar);
        Console.WriteLine("\nIngrese el codigo del producto a modificar: ");
        int modificar = Convert.ToInt32(Console.ReadLine());
        ModificarProducto(inventarios, modificar);
        MostrarInventario(inventarios);
    }

    public static void MostrarInventario(List<Inventario> inventarios)
    {
        foreach (Inventario item in inventarios)
        {
            Console.WriteLine($"Codigo: {item.Codigo} | Producto: {item.Producto} | Stock: {item.Stock}");
        }
    }

    public static void BuscarProducto(List<Inventario> inventarios, int codigo)
    {
        foreach (Inventario item in inventarios)
        {
            if (item.Codigo == codigo)
            {
                Console.WriteLine($"Codigo: {item.Codigo} | Producto: {item.Producto} | Stock: {item.Stock}");
                break;
            }
        }
    }

    public static void ModificarProducto(List<Inventario> inventarios, int codigo)
    {
        foreach (Inventario item in inventarios)
        {
            if (item.Codigo == codigo)
            {
                Console.WriteLine("1 - Producto");
                Console.WriteLine("2 - Codigo");
                int eleccion = Convert.ToInt32(Console.ReadLine());
                if (eleccion == 1)
                {
                    Console.WriteLine("Ingrese nuevo producto: ");
                    var nuevoProducto = Console.ReadLine();
                    item.Producto = nuevoProducto;
                }
                else
                {
                    if (eleccion == 2)
                    {
                        Console.WriteLine("Ingrese el nuevo stock: ");
                        int nuevoStock = Convert.ToInt32(Console.ReadLine());
                        item.Stock = nuevoStock;
                    }
                }
                break;
            }
        }
    }
}
