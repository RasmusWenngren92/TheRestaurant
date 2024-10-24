namespace TheRestaurant;

public class JapaneseChef : Order
{
    public JapaneseChef(string dishName, int cookingTime) : base(dishName, cookingTime)
    {
    }



    public override void Cook()
    {
        Console.WriteLine($"Cooking {DishName}. It takes {CookingTime} milliseconds.");
    }
}