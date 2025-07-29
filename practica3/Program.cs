using System;
//librerias para trabajar con archivos Json
using System.Text.Json;
using System.Text.Json.Serialization;

/*Converti a archivos json, leer y escribir*/
class Programs
{
    // public static void Main(String[] args)
    // {
    //     List<Persona> personas = new List<Persona>();
    //     string ruta = "archivo.json";

    //     if (File.Exists(ruta))
    //     {
    //         //leer archivo json
    //         Console.WriteLine("\nExiste el archivo.");
    //         string jsonLeer = File.ReadAllText(ruta);
    //         // var opcionesLectura = new JsonSerializerOptions
    //         // {
    //         //     PropertyNameCaseInsensitive = true
    //         // };
    //         List<Persona> personaRecuperada = JsonSerializer.Deserialize<List<Persona>>(jsonLeer);//, opcionesLectura);
    //         foreach (Persona item in personaRecuperada)
    //         {
    //             Console.WriteLine($"Nombre: {item.Nombre} | Edad: {item.Edad}");
    //         }
    //     }
    //     else
    //     {
    //         //escribir
    //         Console.WriteLine("\nNo existe el archivo json.");
    //         while (true)
    //         {
    //             Console.WriteLine("Ingrese un nombre: ");
    //             string nombre = Console.ReadLine();
    //             Console.WriteLine("Ingrese su edad: ");
    //             int edad = Convert.ToInt32(Console.ReadLine());
    //             Persona persona = new Persona { Nombre = nombre, Edad = edad };
    //             personas.Add(persona);
    //             Console.WriteLine("Desea Ingresar otro nombre (s/n): ");
    //             var resp = Console.ReadLine();
    //             if (resp != "s") break;

    //         }
    //         var opcion = new JsonSerializerOptions
    //         {
    //             WriteIndented = true,
    //            // PropertyNamingPolicy = JsonNamingPolicy.CamelCase,

    //         };
    //         string json = JsonSerializer.Serialize(personas,opcion);
    //         File.WriteAllText(ruta, json);
    //     }


    // }
    /* Mini App: Agenda de Contactos en JSON
    Objetivo:
    Crear un programa de consola que permita:

    Agregar un nuevo contacto

    Ver todos los contactos

    Buscar contacto por nombre

    Eliminar contacto

    Salir

    Y todos los contactos se guardan en un archivo JSON llamado agenda.json.
    */
    // public static void Main(String[] args)
    // {
    //     List<Agenda> agendas = new List<Agenda>();
    //     string ruta = "agenda.json";

    //     if (File.Exists(ruta))
    //     {
    //         Console.WriteLine("\nExiste el archivo.");
    //         string jsonLeer = File.ReadAllText(ruta);

    //         List<Agenda> contactos = JsonSerializer.Deserialize<List<Agenda>>(jsonLeer);
    //         foreach (Agenda item in contactos)
    //         {
    //             Console.WriteLine($"Nombre: {item.Nombre} | Telefono: {item.Telefono}");
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("\nNo existe el archivo.");
    //         while (true)
    //         {
    //             Console.WriteLine("Ingrese el nombre: ");
    //             string nombre = Console.ReadLine();
    //             Console.WriteLine("Ingrese el Telefono: ");
    //             int telefono = Convert.ToInt32(Console.ReadLine());

    //             Agenda agenda = new Agenda { Nombre = nombre, Telefono = telefono };
    //             agendas.Add(agenda);
    //             Console.WriteLine("Desea ingresar otro contacto? (s/n): ");
    //             var resp = Console.ReadLine();
    //             if (resp != "s") break;
    //         }

    //         var opcion = new JsonSerializerOptions
    //         {
    //             WriteIndented = true,
    //         };

    //         string json = JsonSerializer.Serialize(agendas, opcion);
    //         File.WriteAllText(ruta, json);
    //     }
    // }
    /* Mini App: Gestor de Tareas Pendientes (To-Do List)
     Objetivo:
    Crear una app de consola que permita:

    Agregar tareas

    Marcar tareas como completadas

    Mostrar todas las tareas

    Mostrar solo las tareas pendientes

    Guardar automáticamente en un archivo JSON tareas.json
    */
    public static void Main(String[] args)
    {
        Tareas tareas = new Tareas();
        tareas.Menu();
    }
}


