using System;
using System.IO;

class Program
{

    //escibiendo y leyendo lineas de textos
    public static void Main(String[] args)
    {
        string ruta = "datos.txt";//direccion del archivo
        if (File.Exists("datos.txt"))//verificacion del la existencia del archivo
        {
            Console.WriteLine("\nExiste el archivo\n");//agregar linea
            File.AppendAllText(ruta, "\nOtra linea");//agregar otra linea
            string contenido = File.ReadAllText(ruta);//leer todo el archivo
            Console.WriteLine(contenido);
            string[] lineas = File.ReadAllLines(ruta);//leer linea por linea
            foreach (string linea in lineas)
            {
                Console.WriteLine(linea);
            }

        }
        else
        {
            Console.WriteLine("\nNo existe el archivo, creando archivo\n");

            File.WriteAllText(ruta, "Primera linea");

        }
        

    }
}
