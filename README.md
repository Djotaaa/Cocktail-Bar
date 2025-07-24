# 🍸 Cocktail Bar Console App

C# console app that fetches cocktail information from [TheCocktailDB API](http://www.thecocktaildb.com/api.php).  
Designed as a clean, beginner-friendly and portfolio-worthy project demonstrating API consumption, async/await usage and console UI formatting.

---

## 🔧 Technologies Used

- [.NET 9 Console Application](https://learn.microsoft.com/en-us/dotnet/core/)
- [RestSharp](https://restsharp.dev/) — for making HTTP requests
- [ConsoleTableExt](https://github.com/minhhungit/ConsoleTableExt) — for displaying data in tabular form
- [System.Text.Json](https://learn.microsoft.com/en-us/dotnet/api/system.text.json) — for JSON deserialization

---

## ▶️ How to Run

> Make sure you have [.NET SDK](https://dotnet.microsoft.com/en-us/download) installed.

### ✅ Option 1: Run via Terminal

```bash
cd Cocktail-Info
dotnet build
dotnet run
```

### ✅ Option 2: Run via VS Code

If you're using Visual Studio Code:

- Simply press `F5`, or  
- Click on **Run > Start Debugging**

> This will launch the app in an **external terminal**, as configured in `.vscode/launch.json`.

---

## 📸 Example Output

```plaintext
----- PLEASE ENTER THE COCKTAIL NAME TO SEARCH -----
> Margarita

+--------+------------------+----------------------+---------------+
| ID     | Name             | Category             | Alcoholic     |
+--------+------------------+----------------------+---------------+
| 11007  | Margarita         | Ordinary Drink       | Alcoholic     |
| 11118  | Blue Margarita    | Cocktail             | Alcoholic     |
| ...    | ...               | ...                  | ...           |
+--------+------------------+----------------------+---------------+
```

---
