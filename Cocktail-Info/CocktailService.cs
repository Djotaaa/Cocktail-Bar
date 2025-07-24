using System.Text.Json;
using System.Web;
using RestSharp;

public class CocktailService
{
    private readonly string _apiUrl;

    public CocktailService(string apiUrl)
    {
        _apiUrl = apiUrl;
    }

    public async Task<List<DrinkCategory>?> GetAllCategories()
    {
        var client = new RestClient(_apiUrl);
        var request = new RestRequest("list.php?c=list");
        var response = await client.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var content = response.Content;
            var jsonResponse = JsonSerializer.Deserialize<DrinkCategoryResponse>(content);
            return jsonResponse?.CategoriesList;
        }
        else
        {
            return null;
        }
    }

    public async Task<List<DrinkByCategory>?> GetCategory(string userInput)
    {
        var client = new RestClient(_apiUrl);
        var request = new RestRequest($"filter.php?c={HttpUtility.UrlEncode(userInput)}");
        Console.Clear();
        Console.Write("Loading...");
        var response = await client.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var content = response.Content;
            var jsonResponse = JsonSerializer.Deserialize<DrinksByCategoryList>(content);
            var drinks = jsonResponse?.ListOfDrinks;

            return drinks;
        }
        else
        {
            return null;
        }
    }

    public async Task<List<DrinkSearch>?> GetName(string userInput)
    {
        var client = new RestClient(_apiUrl);
        var request = new RestRequest($"search.php?s={HttpUtility.UrlEncode(userInput)}");
        Console.Clear();
        Console.Write("Loading...");
        var response = await client.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var content = response.Content;
            var jsonResponse = JsonSerializer.Deserialize<DrinkSearchList>(content);
            var drinks = jsonResponse?.ListOfDrinks;

            return drinks;
        }
        else
        {
            return null;
        }
    }

    public async Task<List<DrinkSearch>?> GetFirstLetter(string userInput)
    {
        var client = new RestClient(_apiUrl);
        var request = new RestRequest($"search.php?f={HttpUtility.UrlEncode(userInput)}");
        Console.Clear();
        Console.Write("Loading...");
        var response = await client.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var content = response.Content;
            var jsonResponse = JsonSerializer.Deserialize<DrinkSearchList>(content);
            var drinks = jsonResponse?.ListOfDrinks;

            return drinks;
        }
        else
        {
            return null;
        }
    }

    public async Task<List<DrinkSearch>?> GetRandom()
    {
        var client = new RestClient(_apiUrl);
        var request = new RestRequest("random.php");
        Console.Clear();
        Console.Write("Loading...");
        var response = await client.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var content = response.Content;
            var jsonResponse = JsonSerializer.Deserialize<DrinkSearchList>(content);
            var drinks = jsonResponse?.ListOfDrinks;

            return drinks;
        }
        else
        {
            return null;
        }
    }
}