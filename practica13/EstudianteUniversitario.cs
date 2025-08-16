using System;
using System.Diagnostics.CodeAnalysis;

class EstudianteUniversitario : Estudiante
{
    private List<(double nota, int credito)> materias;

    public EstudianteUniversitario(string nombre, int dni) : base(nombre, dni)
    {
        materias = new List<(double, int)>();
    }

    public void AgregarMaterias(double notas, int credito)
    {
        materias.Add((notas, credito));
    }

    public override double CalcularPromedio()
    {
        double totalPonderado = materias.Sum(m => m.nota * m.credito);
        int totalCreditos = materias.Sum(m => m.credito);
        return totalCreditos > 0 ? totalPonderado / totalCreditos : 0;
    }
}