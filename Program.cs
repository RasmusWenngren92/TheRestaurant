using Spectre.Console;

namespace TheRestaurant;

class Program
{
    public static void Main(string[] args)
    {

        Menu.PrintMenu();
        var restaurant = new Restaurant();

// Simulera beställningard
        _ = Restaurant.AddOrder(new ItalianChef("Sushi", 5000));
        _ = Restaurant.AddOrder(new JapaneseChef("Pizza", 2500));
        _ = Restaurant.AddOrder(new WesternChef("Burger", 3000));

// Hålla programmet vid liv så att alla uppgifter hinner avslutas
        
        Console.WriteLine($"Waiting for {Restaurant.OrderTaken(restaurant)} orders to be processed...");
       Task.Delay(10000).Wait(); // Vänta i 10 sekunder för att alla rätter ska bli klara
       Console.WriteLine($"Now {Restaurant.OrderDelivered(restaurant)} orders is served");
       Task.Delay(10000).Wait();
    }
}

