using System;

class Libro : Publicacion
{
    public int Paginas { get; private set; }
    public Libro(string titulo, string nombre, int paginas) : base(titulo, nombre)
    {
        Paginas = paginas;
    }

    public override string Descripcion()
    {
        return $"Libro: {Titulo} - {Paginas} paginas";
    }
}