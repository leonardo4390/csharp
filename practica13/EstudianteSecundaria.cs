using System;

class EstudianteSecundaria : Estudiante
{
    private double[] notas;

    public EstudianteSecundaria(string nombre, int dni, double nota1, double nota2, double nota3) : base(nombre, dni)
    {
        notas = new double[] { nota1, nota2, nota3 };
    }

    public override double CalcularPromedio()
    {
        return notas.Average();
    }
}