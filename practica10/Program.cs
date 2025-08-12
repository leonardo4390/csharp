using System;
using System.Xml;

/*
    Ejercicio 2: Sistema de Biblioteca
Enunciado:
Crear un sistema que administre libros y revistas en una biblioteca.
Debe cumplir con lo siguiente:

Clase abstracta Publicacion con:

Propiedades Titulo y Autor.

Método abstracto Descripcion().

Método sobrecargado Descripcion(bool incluirAutor).

Clases derivadas:

Libro (agrega NumeroPaginas).

Revista (agrega NumeroEdicion).

Implementar encapsulamiento para que Titulo y Autor sean de solo lectura.

Crear una lista de publicaciones y recorrerla mostrando descripciones usando polimorfismo.
*/

class Program
{
    public static void Main(String[] args)
    {
        List<Publicacion> publicacions = new List<Publicacion>();

        Publicacion publicacion = new Revista("gente", "varios", 4);
        Publicacion publicacion1 = new Libro("el señor de los anillos", "tolkies", 800);
        publicacions.Add(publicacion);
        publicacions.Add(publicacion1);

        foreach (var item in publicacions)
        {
            Console.WriteLine(item.Descripcion());
            Console.WriteLine(item.Descripcion(true));
            Console.WriteLine();
        }
    }

}
