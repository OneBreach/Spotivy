namespace Spotivy;

using System.IO;
using System.Text.Json;
using System.Collections.Generic;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Spotivy!");
        Console.WriteLine("Please enter your name:");
        var name = Console.ReadLine();

        var userDataJson = File.ReadAllText("userData.json");
        var userData = JsonSerializer.Deserialize<List<User>>(userDataJson);
        Console.WriteLine(userDataJson);



        if (userData != null)
            foreach (var user in userData.Where(user => user.Name == name))
            {
                Console.WriteLine($"Welcome back, {user.Name}!");
                return;
            }


        Console.WriteLine($"Welcome, {name}!");
    }
}