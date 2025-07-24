using ConsoleTableExt;

public class TableVisualisator
{
    internal static void ShowTable<T>(List<T> tableData, string tableTitle) where T : class
    {
        Console.Clear();
        
        ConsoleTableBuilder
        .From(tableData)
        .WithTitle(tableTitle)
        .ExportAndWriteLine();

    }
}