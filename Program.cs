using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // API URL
        string apiUrl = "https://api.rawg.io/api/games?key=e0c7cdef9d5748f08459d0692c99cbed";

        // Call the API and store the result in a list of games
        var games = await GetGames(apiUrl);

        // Print some information from the retrieved data
        foreach (var game in games)
        {
            Console.WriteLine($"Game Name: {game.Name}");
            Console.WriteLine($"Release Date: {game.Released}");
            Console.WriteLine($"Background Image: {game.BackgroundImage}");
            Console.WriteLine();
        }
    }

    static async Task<List<GameData>> GetGames(string apiUrl)
    {
        using (HttpClient client = new HttpClient())
        {
            // Make a GET request to the API
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                // Read the content of the response
                string responseBody = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON response into a RootObject containing a list of GameData
                var rootObject = JsonConvert.DeserializeObject<RootObject>(responseBody);

                return rootObject?.Results;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
                return null;
            }
        }
    }
}

// Define classes to represent the structure of the JSON data
public class GameData
{
    public string Name { get; set; }
    public string BackgroundImage { get; set; }
    public string Released { get; set; }
}

public class RootObject
{
    public List<GameData> Results { get; set; }
}
