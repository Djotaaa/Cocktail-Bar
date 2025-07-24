internal class Program
{
    public static async Task Main()
    {
        var cocktailService = new CocktailService("http://www.thecocktaildb.com/api/json/v1/1/");
        var requestsHandler = new RequestsHandler(cocktailService);

        MessageConstants.WelcomeMessage();

        await Menu.ShowMenu(requestsHandler);
    }
}
