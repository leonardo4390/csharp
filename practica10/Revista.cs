using System;

class Revista : Publicacion
{
    public int Edicion { get; private set; }

    public Revista(string titulo, string nombre, int edicion) : base(titulo, nombre)
    {
        Edicion = edicion;
    }

    public override string Descripcion()
    {
        return $"Revista: {Titulo} - Edicion N°: {Edicion}";
    }
}