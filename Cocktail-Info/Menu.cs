using System.Threading.Tasks;

public class Menu
{
    internal static async Task ShowMenu(RequestsHandler requestsHandler)
    {
        MessageConstants.MenuMessage();

        var userInput = Console.ReadLine();

        switch (userInput)
        {
            case "0":
                MessageConstants.GoodByeMessage();
                break;
            case "1":
                Console.Clear();
                await requestsHandler.GetByName();
                break;
            case "2":
                Console.Clear();
                await requestsHandler.GetByFirstLetter();
                break;
            case "3":
                Console.Clear();
                await requestsHandler.GetByCategory();
                break;
            case "4":
                Console.Clear();
                await requestsHandler.GetRandomCocktail();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Invalid input. We redirecting you to Menu again...");
                Thread.Sleep(2000);
                await ShowMenu(requestsHandler);
                break;
        }
    }

}