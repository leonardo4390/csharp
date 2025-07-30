using System;
using System.Text.Json;
using System.Threading.Tasks;


class ConsumoAPI
{
    private string url = "https://ws.smn.gob.ar/map_items/weather/";

    public async Task<List<Ciudad>> ObtenerDatos()
    {
        // crear instancia 
        HttpClient client = new HttpClient();
        // enviar solicitud Get
        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        // leer solicitud y deserializar respuesta
        string responseBody = await response.Content.ReadAsStringAsync();

        var ciudades = JsonSerializer.Deserialize<List<Ciudad>>(responseBody);
        // foreach (var ciudad in ciudades)
        // {
        //     Console.WriteLine($"Ciudad: {ciudad.name}, Provincia: {ciudad.province}");
        //     Console.WriteLine($"Clima: {ciudad.weather.description}");
        //     Console.WriteLine($"Temperatura: {ciudad.weather.tempDesc}");
        //     Console.WriteLine(new string('-', 40));
        // }

        return ciudades;
    }
}