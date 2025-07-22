using System;
using System.IO;

class Program
{
    /* Ejercicio 1: Leer un archivo de texto
Crea un programa que lea un archivo llamado datos.txt y muestre su contenido línea por línea en consola.*/
    //escibiendo y leyendo lineas de textos
    // public static void Main(String[] args)
    // {
    //     string ruta = "datos.txt";//direccion del archivo
    //     if (File.Exists("datos.txt"))//verificacion del la existencia del archivo
    //     {
    //         Console.WriteLine("\nExiste el archivo\n");//agregar linea
    //         File.AppendAllText(ruta, "\nOtra linea");//agregar otra linea
    //         string contenido = File.ReadAllText(ruta);//leer todo el archivo
    //         Console.WriteLine(contenido);
    //         string[] lineas = File.ReadAllLines(ruta);//leer linea por linea
    //         foreach (string linea in lineas)
    //         {
    //             Console.WriteLine(linea);
    //         }

    //     }
    //     else
    //     {
    //         Console.WriteLine("\nNo existe el archivo, creando archivo\n");

    //         File.WriteAllText(ruta, "Primera linea");

    //     }


    // }
    /*Ejercicio 2: Escribir nombres en un archivo
Pedí al usuario que ingrese 5 nombres por consola y guardalos en un archivo nombres.txt, uno por línea.

Tips:*/
    // public static void Main(String[] args)
    // {
    //     string ruta2 = "nombres.txt";
    //     int count = 0;
    //     if (File.Exists(ruta2))
    //     {
    //         Console.WriteLine("\nExiste el archivo");
    //         Console.WriteLine("Ingrese un nombre: ");
    //         string nombre = Console.ReadLine();
    //         File.AppendAllText(ruta2, nombre + Environment.NewLine);
    //         count++;
    //     }
    //     else
    //     {
    //         Console.WriteLine("\nNo existe el archivo");
    //         while (count < 5)
    //         {
    //             Console.WriteLine("Ingrese un nombre: ");
    //             string nombre = Console.ReadLine();
    //             File.AppendAllText(ruta2, nombre + Environment.NewLine);
    //             count++;
    //         }

    //     }
    // }

    /*Ejercicio 3: Contar líneas y palabras
Leé un archivo texto.txt y mostrá:

Cuántas líneas tiene.

Cuántas palabras tiene (separadas por espacio).

Tips:

Usá Split(' ') para separar palabras.*/
    // public static void Main(String[] args)
    // {
    //     string ruta3 = "ejercicio3.txt";
    //     // int count = 0;
    //     // if (File.Exists(ruta3))
    //     // {
    //     //     Console.WriteLine("\nExiste el archivo");
    //     //     while (count < 5)
    //     //     {
    //     //         Console.WriteLine("Ingrese el nombre y apellido");
    //     //         string nombreApellido = Console.ReadLine();
    //     //         File.AppendAllText(ruta3, nombreApellido + Environment.NewLine);
    //     //         count++;
    //     //     }
    //     // }
    //     // else
    //     // {
    //     //     Console.WriteLine("\nNo existe el archivo");
    //     //     while (count < 5)
    //     //     {
    //     //         Console.WriteLine("Ingrese el nombre y apellido");
    //     //         string nombreApellido = Console.ReadLine();
    //     //         File.AppendAllText(ruta3, nombreApellido + Environment.NewLine);
    //     //         count++;
    //     //     }
    //     // }

    //     // string contenido = File.ReadAllText(ruta3);
    //     // Console.WriteLine(contenido);
    //     // string[] palabras = contenido.Split(new[] { ' '});
    //     // Console.WriteLine(palabras.Length);

    // }
    /* Ejercicio 4: Copiar un archivo
Creá un programa que copie el contenido de un archivo origen.txt a otro llamado copia.txt.

Bonus: Si copia.txt ya existe, preguntale al usuario si quiere sobrescribirlo.

Tips:

Usá File.Copy.*/
    // public static void Main(String[] args)
    // {
    //     string ruta4 = "copia.txt";
    //     if (File.Exists(ruta4))
    //     {
    //         Console.WriteLine("\nExiste el archivo copia.txt, Desea remplazarlo? (s/n)");
    //         var resp = Console.ReadLine();
    //         if (resp == "s")
    //         {
    //             File.Copy("ejercicio3.txt", ruta4, true);
    //             string contenido = File.ReadAllText(ruta4);
    //             Console.WriteLine(contenido);
    //         }

    //     }
    //     else
    //     {
    //         File.Copy("ejercicio3.txt", ruta4);
    //         string contenido = File.ReadAllText(ruta4);
    //         Console.WriteLine(contenido);
    //     }
    // }

    /*Ejercicio 5: Agenda básica (crear o leer contactos)
Hacé un programa que permita al usuario:

Agregar un nuevo contacto a agenda.txt, con nombre y teléfono (separados por coma).

Leer todos los contactos existentes.*/
    public static void Main(String[] args)
    {
        string ruta5 = "agenda.txt";
        if (File.Exists(ruta5))
        {
            Console.WriteLine("\nExiste el archivo");
            while (true)
            {
                Console.WriteLine("Ingrese el nombre del contacto: ");
                var nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el telefono: ");
                int telefono = Convert.ToInt32(Console.ReadLine());
                File.AppendAllText(ruta5, nombre + ',');
                File.AppendAllText(ruta5, telefono + Environment.NewLine);
                Console.WriteLine("Desea agregar otro contacto? (s/n): ");
                var resp = Console.ReadLine();
                if (resp != "s")
                {
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("\nNo existe el archivo, creando");
            while (true)
            {
                Console.WriteLine("Ingrese el nombre del contacto: ");
                var nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el telefono: ");
                int telefono = Convert.ToInt32(Console.ReadLine());
                File.AppendAllText(ruta5, nombre + ',');
                File.AppendAllText(ruta5, telefono + Environment.NewLine);
                Console.WriteLine("Desea agregar otro contacto? (s/n): ");
                var resp = Console.ReadLine();
                if (resp != "s")
                {
                    break;
                }
            }
        }
        string contactos = File.ReadAllText(ruta5);
        Console.WriteLine(contactos);
    }
}
