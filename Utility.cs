namespace Spotivy;

public static class Utility
{
    public static string SelectFromList(List<string> options)
    {
        var currentIndex = 0;
        while (true)
        {
            Console.Clear();

            for (var i = 0; i < options.Count; i++)
            {
                if (i == currentIndex)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                Console.WriteLine($"- {options[i]}");

                Console.ResetColor();
            }

            var key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    currentIndex = (currentIndex - 1 + options.Count) % options.Count;
                    continue;
                case ConsoleKey.DownArrow:
                    currentIndex = (currentIndex + 1) % options.Count;
                    continue;
                case ConsoleKey.Enter:
                    Console.Clear();
                    return options[currentIndex];
            }
        }
    }
// Be able to select multiple items from a list of Any type


    public static List<string> SelectMultipleFromList(List<string> options)
    {
        var currentIndex = 0;
        var selectedItems = new List<string>();
        while (true)
        {
            Console.Clear();

            for (var i = 0; i < options.Count; i++)
            {
                if (i == currentIndex)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                if (selectedItems.Contains(options[i]))
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                }

                Console.WriteLine($"- {options[i]} {(selectedItems.Contains(options[i]) ? "(selected)" : "")}");

                Console.ResetColor();
            }
            Console.WriteLine("Press space to confirm selection.");

            var key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    currentIndex = (currentIndex - 1 + options.Count) % options.Count;
                    continue;
                case ConsoleKey.DownArrow:
                    currentIndex = (currentIndex + 1) % options.Count;
                    continue;
                case ConsoleKey.Enter:
                    var selectedItem = options[currentIndex];
                    if (selectedItems.Contains(selectedItem))
                    {
                        selectedItems.Remove(selectedItem);
                    }
                    else
                    {
                        selectedItems.Add(selectedItem);
                    }
                    continue;
                case ConsoleKey.Spacebar:
                    Console.Clear();
                    return selectedItems;
            }
        }
    }

    public static void PressAnyKeyToContinue()
    {
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
}