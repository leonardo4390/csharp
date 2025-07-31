using System;
using System.Threading.Tasks;


class Program
{
    // public static async Task Main(String[] args)
    // {
    //     ConsumoAPI consumoAPI = new ConsumoAPI();
    //     List<Ciudad> ciudads = await consumoAPI.ObtenerDatos();
    //     // await consumoAPI.ObtenerDatos();

    //     Console.Write("Ingrese una Provincia: ");
    //     var nombre = Console.ReadLine();

    //     var ciudadesFiltradas = ciudads.Where(c => c.name.Equals(nombre, StringComparison.OrdinalIgnoreCase)).ToList();
    //     if (ciudadesFiltradas.Count == 0)
    //     {
    //         Console.WriteLine($"No se encontraron datos para la provincia '{nombre}'.");
    //     }
    //     else
    //     {
    //         Console.WriteLine($"\nDatos meteorológicos para {nombre}:\n");
    //         foreach (var ciudad in ciudadesFiltradas)
    //         {
    //             Console.WriteLine($"Ciudad: {ciudad.name}");
    //             Console.WriteLine($"Temperatura: {ciudad.weather.tempDesc}");
    //             Console.WriteLine($"Clima: {ciudad.weather.description}");
    //         }
    //     }

    // }
    /*
        Objetivo:
    Hacer un GET a /posts

    Mostrar los títulos de las primeras 10 publicaciones.

    Aprendés:
    Hacer un GET

    Leer una lista de objetos JSON

    Usar JsonSerializer.Deserialize<List<Post>>()
    */
    // public static async Task Main(String[] args)
    // {
    //     ApiPublicaciones publicaciones = new ApiPublicaciones();
    //     List<Publicaciones> primeras = await publicaciones.ObtenerDatos();

    //     foreach (var item in primeras)
    //     {
    //         Console.WriteLine($"Id: {item.id} | Titulo: {item.title}");
    //     }
    // }
    /*
            Objetivo:
    Permitir al usuario escribir el nombre de un país (ej. "Argentina")

    Hacer un GET a https://restcountries.com/v3.1/name/argentina

    Mostrar capital, población y continente.
    */

    public static async Task Main(String[] args)
    {
        ApiPais pais = new ApiPais();
        List<Pais> descripcion = await pais.ObtenerDatos();

        foreach (var item in descripcion)
        {
            Console.WriteLine($"Pais: {item.name.official} | Capital: {item.capital[0]} | Poblacion: {item.population} | Continente: {item.region}");
        }
    }
}
