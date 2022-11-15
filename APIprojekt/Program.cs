using RestSharp;
using System.Text.Json;
using System.Net;
RestClient pokeClient = new("https://pokeapi.co/api/v2/");
RestRequest request = new("pokemon/kadabra");
RestResponse response = pokeClient.GetAsync(request).Result;

if (response.StatusCode == HttpStatusCode.OK)
{
    pokemon p = JsonSerializer.Deserialize<pokemon>(response.Content);
    Console.WriteLine(p.name);
    Console.WriteLine(p.weight);
}
else
{
    Console.WriteLine("Wrong");
}

// Console.WriteLine(response.StatusCode);

Console.ReadLine();
