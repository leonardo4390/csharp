using System;
using System.Text.Json;
using System.Threading.Tasks;


class ApiPais
{
    private string url = "https://restcountries.com/v3.1/name/";

    public async Task<List<Pais>> ObtenerDatos()
    {
        Console.WriteLine("Ingrese un nombre de un pais: ");
        var pais = Console.ReadLine();
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(url + pais.ToLower());
        response.EnsureSuccessStatusCode();

        string responseBody = await response.Content.ReadAsStringAsync();
        var contenido = JsonSerializer.Deserialize<List<Pais>>(responseBody);

        return contenido;

    }
}