using System.ComponentModel.Design.Serialization;
using System.Text.Json;
using System.Web;
using ConsoleTableExt;
using Microsoft.VisualBasic;
using RestSharp;

internal class RequestsHandler
{
    private readonly CocktailService _cocktailService;
    public RequestsHandler(CocktailService cocktailService)
    {
        _cocktailService = cocktailService;
    }

    public async Task GetByCategory()
    {
        Console.Write("Loading...");
        var categories = await _cocktailService.GetAllCategories();
        if (categories != null)
        {
            Console.Clear();
            TableVisualisator.ShowTable(categories, "Categories");
            Console.WriteLine("You can see all categories in table. Please insert category to filter cocktails:");
            Console.WriteLine("----- PLEASE ENTER THE NAME EXACTLY AS IT IS SHOWN IN THE TABLE -----");

            string? userInput = Console.ReadLine();
            while (userInput == null || userInput.Trim() == "" || !categories.Any(x => x.Category == userInput))
            {
                Console.WriteLine("Invalid input. Make sure you entered right category:");
                Console.WriteLine("----- PLEASE ENTER THE NAME EXACTLY AS IT IS SHOWN IN THE TABLE -----");
                userInput = Console.ReadLine();
            }

            var drinkList = await _cocktailService.GetCategory(userInput);

            if (drinkList != null)
            {
                TableVisualisator.ShowTable(drinkList, $"Category: {userInput}");

                Console.WriteLine("\t If you want to go back to Caterogies List - press 1");
                Console.WriteLine("\t If you want to go back to Menu - press 0");
                userInput = Console.ReadLine();

                if (userInput?.Trim() == "1")
                {
                    Console.Clear();
                    await GetByCategory();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Loading...");
                    Thread.Sleep(1000);
                    await Menu.ShowMenu(this);
                }

            }
            else
            {
                await UnsuccessfulResponse();
            }


        }
        else
        {
            Console.WriteLine("Currently we are unable to provide categories. \nPress any key to go to Menu...");
            Console.ReadKey();
            await Menu.ShowMenu(this);
        }
    }

    public async Task GetByName()
    {
        Console.WriteLine("----- PLEASE ENTER THE COCKTAIL NAME TO SEARCH -----");
        string? userInput = Console.ReadLine();
        while (userInput == null || userInput.Trim() == "")
        {
            Console.WriteLine("You didn't entered anything, please enter again:");
            userInput = Console.ReadLine();
        }

        var drinks = await _cocktailService.GetName(userInput);

        if (drinks != null)
        {
            await TableDataResponse(drinks, userInput, "name");
        }
        else
        {
            await UnsuccessfulResponse();
        }
    }

    public async Task GetByFirstLetter()
    {
        Console.WriteLine("----- PLEASE ENTER THE FIRST LETTER TO SEARCH COCKTAIL -----");
        string? userInput = Console.ReadLine();
        while (userInput == null || userInput.Trim() == "" || userInput.Length > 1)
        {
            Console.WriteLine("Invalid input. Please enter only one letter:");
            userInput = Console.ReadLine();
        }

        var drinks = await _cocktailService.GetFirstLetter(userInput);

        if (drinks != null)
        {
            await TableDataResponse(drinks, userInput, "letter");
        }
        else
        {
            await UnsuccessfulResponse();
        }
    }

    public async Task GetRandomCocktail()
    {
        Console.WriteLine("----- PRESS ANY KEY TO GET RANDOM COCKTAIL -----");
        Console.ReadKey();

        var drinks = await _cocktailService.GetRandom();

        if (drinks != null)
        {
            TableVisualisator.ShowTable(drinks, "Random Drink");
            MessageConstants.UnderTableMessage();
            await Menu.ShowMenu(this);
        }
        else
        {
            await UnsuccessfulResponse();
        }
    }

    private async Task UnsuccessfulResponse()
    {
        MessageConstants.UnsuccessfulResponseMessage();
        await Menu.ShowMenu(this);
    }

    private async Task TableDataResponse<T>(List<T> list, string userInput, string searchType) where T : class
    {
        TableVisualisator.ShowTable(list, $"Drinks for {searchType}: {userInput}");
        MessageConstants.UnderTableMessage();
        await Menu.ShowMenu(this);
    }

}