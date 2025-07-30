using System;
using System.Threading.Tasks;


class Program
{
    public static async Task Main(String[] args)
    {
        ConsumoAPI consumoAPI = new ConsumoAPI();
        List<Ciudad> ciudads = await consumoAPI.ObtenerDatos();
        // await consumoAPI.ObtenerDatos();

        Console.Write("Ingrese una Provincia: ");
        var nombre = Console.ReadLine();

        var ciudadesFiltradas = ciudads.Where(c => c.name.Equals(nombre, StringComparison.OrdinalIgnoreCase)).ToList();
        if (ciudadesFiltradas.Count == 0)
        {
            Console.WriteLine($"No se encontraron datos para la provincia '{nombre}'.");
        }
        else
        {
            Console.WriteLine($"\nDatos meteorológicos para {nombre}:\n");
            foreach (var ciudad in ciudadesFiltradas)
            {
                Console.WriteLine($"Ciudad: {ciudad.name}");
                Console.WriteLine($"Temperatura: {ciudad.weather.tempDesc}");
                Console.WriteLine($"Clima: {ciudad.weather.description}");
            }
        }



        

    }
}
