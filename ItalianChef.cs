namespace TheRestaurant;

public class ItalianChef : Order
{
    public ItalianChef(string dishName, int cookingTime) : base(dishName, cookingTime)
    {
    }

    public override void Cook()
    {
        Console.WriteLine($"Cooking {DishName}. It takes {CookingTime} milliseconds.");
    }
}