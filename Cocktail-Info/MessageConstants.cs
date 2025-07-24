public static class MessageConstants
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("\tWelcome to Cockail Bar!!!\n-------------------------------------------------");
        Console.WriteLine("To view the offer in our Bar - press any key...");
        Console.ReadLine();
    }

    public static void MenuMessage()
    {
        Console.Clear();
        Console.WriteLine("Hello! We have a whole bunch of cocktails, tell us:");
        Console.WriteLine("\t------------------------------");
        Console.WriteLine("If you want to search by name -------------------------- press 1");
        Console.WriteLine("If you want to search cocktail by first letter --------- press 2");
        Console.WriteLine("If you want to search by category ---------------------- press 3");
        Console.WriteLine("If you want to get a random cocktail ------------------- press 4");
        Console.WriteLine("\t------------------------------");
        Console.WriteLine("\t\tTo exit - press 0");
        Console.WriteLine("\t------------------------------");
    }

    public static void GoodByeMessage()
    {
        Console.Clear();
        Console.WriteLine("Good bye! See you next time at our Cocktail Bar!!!");
        Thread.Sleep(2500);
        Environment.Exit(0);
    }

    public static void UnsuccessfulResponseMessage()
    {
        Console.Clear();
        Console.WriteLine("We are currently unable to provide the data.");
        Console.WriteLine("Press any key to return to Menu...");
        Console.ReadKey();
    }

    public static void UnderTableMessage()
    {
        Console.WriteLine("\t----- Press any key to return to Menu -----");
        Console.ReadKey();
    }
}