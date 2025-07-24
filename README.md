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

## ✨ Features

### Search by Name
- Enter the part or full name of a cocktail (e.g. typing "sang" will return "Sangria" and similar matches).
- The app will fetch and display detailed information such as name, category and alcohol content.
- Uses **asynchronous HTTP calls** via **RestSharp** and **JSON deserialization** via `System.Text.Json`.

### Search by First Letter
- Enter a single character (e.g. "m") to get a list of all cocktails starting with that letter.
- Useful for exploration and discovery of new drinks.

### Browse by Category
- Choose from available drink categories (e.g. "Ordinary Drink", "Cocktail", "Shake").
- You must enter exact name of cocktail category.
- Once a category is selected, a list of all drinks in that category is shown.
- Categories are retrieved dynamically from the API.

### Get a Random Cocktail
- Fetches a completely random cocktail from the API.
- Great for getting drink inspiration or trying something new.

### Clean Table Output
- All results are displayed using the **ConsoleTableExt** library to provide well-formatted and readable output in the terminal.

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

- Simply press `F5` or  
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
