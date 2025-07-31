using System;
using System.Text.Json;
using System.Threading.Tasks;


class ApiPublicaciones
{
    private string url = "https://jsonplaceholder.typicode.com/posts";

    public async Task<List<Publicaciones>> ObtenerDatos()
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();

        string responseBody = await response.Content.ReadAsStringAsync();

        var publicaciones = JsonSerializer.Deserialize<List<Publicaciones>>(responseBody);

        return publicaciones.Take(10).ToList() ?? new List<Publicaciones>();

    }
}