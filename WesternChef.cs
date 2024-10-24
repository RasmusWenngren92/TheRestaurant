namespace TheRestaurant;

public class WesternChef : Order
{
    public WesternChef(string dishName, int cookingTime) : base(dishName, cookingTime)
    {
    }

    public override void Cook()
    {
        Console.WriteLine($"Cooking {DishName}. It takes {CookingTime} milliseconds.");
    }
}