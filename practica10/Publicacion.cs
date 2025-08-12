using System;

abstract class Publicacion
{

    public string Titulo { get; private set; }
    public string Autor { get; private set; }

    public Publicacion(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }

    public abstract string Descripcion();

    public string Descripcion(bool incluirAutor)
    {
        return incluirAutor ? $"{Titulo} - {Autor}": Titulo;
    }
}