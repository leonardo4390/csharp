using System;


class Refugio
{
    private List<Animal> animals = new List<Animal>();

    public void AgregarAnimal(Animal animal)
    {
        animals.Add(animal);
        Console.WriteLine($"{animal.Nombre} agregado al Refugio.");
    }

    public void MostrarAnimales()
    {
        foreach (var item in animals)
        {
            item.MostrarInfo();
            item.EmitirSonido();
            Console.WriteLine();
        }
    }

    public Animal BuscarPorNombre(string nombre)
    {
        return animals.Find(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }
}