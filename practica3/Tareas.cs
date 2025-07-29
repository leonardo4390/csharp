using System;
using System.Text.Json;
using System.Text.Json.Serialization;

class Tareas
{

    public void Menu()
    {
        List<Personal> pendientes = new List<Personal>();
        List<Personal> realizadas = new List<Personal>();
        string ruta = "tareas.json"; 
        int id = 0;

        while (true)
        {
            id++;
            Console.WriteLine("\n\t******Menu******\n");
            Console.WriteLine("\t1 - Agregar Tareas");
            Console.WriteLine("\t2 - Marcar Tareas como completada");
            Console.WriteLine("\t3 - Mostrar Todas las Tareas");
            Console.WriteLine("\t4 - Mostrar solo las Tareas Pendientes");
            Console.WriteLine("\t5 - Guardar automaticamente en un archivo Json\n");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el nombre del Personal: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese la Tarea a realizar: ");
                    string tarea = Console.ReadLine();
                    Personal personal = new Personal { Nombre = nombre, Tarea = tarea, Id = id };
                    pendientes.Add(personal);
                    break;

                case 2:
                    Console.WriteLine("Ingrese el id de la tarea a marcar: ");
                    int idMarcar = Convert.ToInt32(Console.ReadLine());
                    foreach (Personal item in pendientes)
                    {
                        if (item.Id == idMarcar)
                        {
                            realizadas.Add(item);
                            pendientes.Remove(item);
                            Console.WriteLine("Tarea marcada.");
                            break;
                        }
                    }
                    break;
                case 3:
                    if (pendientes.Count != 0)
                    {
                        Console.WriteLine("\nTareas Pendientes.");
                        MostrarTareas(pendientes);
                    }
                    else
                    {
                        Console.WriteLine("No hay tareas a mostrar.");
                    }
                    if (realizadas.Count != 0)
                    {
                        Console.WriteLine("\nTareas Realizadas.");
                        MostrarTareas(realizadas);

                    }
                    else
                    {
                        Console.WriteLine("No hay tareas a mostrar.");
                    }
                    break;
                case 4:
                    if (realizadas.Count != 0)
                    {
                        Console.WriteLine("\nTareas Realizadas.");
                        MostrarTareas(realizadas);

                    }
                    else
                    {
                        Console.WriteLine("No hay tareas a mostrar.");
                    }
                    break;
                case 5:
                    Console.WriteLine("Desea guardar Tareas Pendientes?(s/n)");
                    var resp = Console.ReadLine();
                    if (resp == "s")
                    {
                        if (pendientes.Count != 0)
                        {
                            Console.WriteLine("Guardado exitoso.");
                            GuardarTareas(pendientes, ruta);
                        }
                        else
                        {
                            Console.WriteLine("No hay tareas a guardar.");
                        }
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("Desea Continuar? (s/n): ");
            var seguir = Console.ReadLine();
            if (seguir != "s") break;
        }



    }

    public static void MostrarTareas(List<Personal> lista)
    {
        foreach (Personal item in lista)
        {
            Console.WriteLine($"Id : {item.Id} | Nombre: {item.Nombre} | Tarea: {item.Tarea}");
        }

    }

    public static void GuardarTareas(List<Personal> lista, string ruta)
    {
        if (File.Exists(ruta))
        {
            Console.WriteLine("Existe la ruta.");
            string jsonleer = File.ReadAllText(ruta);
            List<Personal> personals = JsonSerializer.Deserialize<List<Personal>>(jsonleer);
            foreach (Personal item in personals)
            {
                Console.WriteLine($"Id : {item.Id} | Nombre: {item.Nombre} | Tarea: {item.Tarea}");
            }

        }
        else
        {
            Console.WriteLine("No existe la ruta del archivo.");
            var opcion = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(lista, opcion);
            File.WriteAllText(ruta, json);
        }
    }
    

}