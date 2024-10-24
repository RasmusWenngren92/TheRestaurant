using System.Globalization;
using System.Net.Sockets;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using Spectre.Console;

namespace TheRestaurant;

public static class Menu
{
    public static void PrintMenu()
    {
        while (true)
        {
            var menu = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Welcome to our Restaurant! How can I help you?")
                    .PageSize(15)
                    .AddChoices("Look at the Menu", "Drinks List", "Leave the Restaurant"));

            switch (menu)
            {
                case "Look at the Menu":
                    TheMenu();
                    break;
                case "Drinks List":
                    Drinks();
                    break;
                case "Leave the Restaurant":
                    Console.WriteLine("Welcome back another time!");
                    Thread.Sleep(2000);
                    return;
            }
        }
    }

    private static async Task TheMenu()
    {
        var kitchen = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("We have food from all the world, any particular food you would like to eat?")
                .PageSize(15)
                .AddChoices("Japanese food", "Italian food", "Western food", "Show me everything", "Im good thanks!", "I changed my mind, I would like to see the drink list."));
        switch (kitchen)
        {
            case "Japanese food":
                await JapaneseFood();
                break;
            case "Italian food":
                break;
            case "Western food":
                break;
            case "Show me everything":
                break;
            case "Im good thanks":
                return;
            case "I changed my mind, I would like to see the drink list.":
                break;
            
        }
    }

    private static void Drinks()
    {
        
    }

    private static async Task JapaneseFood(int cookingTime = 0)
    {
        var dishes = AnsiConsole.Prompt(
            new MultiSelectionPrompt<string>()
                .Title("どうぞ, here is the Japanese Menu.")
                .NotRequired()
                .PageSize(15)
                .InstructionsText("[grey](Press [red]<space>[/] to toggle a dish," +
                                  "[green]<enter>[/] to accept[/]")
                .AddChoices("Sushi", "Yakitori", "Udon ", "Unagi", "Wagashi"));
        foreach (var dish in dishes)
        {
            await Restaurant.AddOrder(new JapaneseChef(dish, cookingTime));
        }
       
    }

}