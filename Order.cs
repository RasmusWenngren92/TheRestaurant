namespace TheRestaurant;

public abstract class Order
{
      public string DishName { get; set; }
      public int CookingTime { get; set; }
   
   protected Order(string dishName, int cookingTime)
   {
      DishName = dishName;
      CookingTime = cookingTime;
   }
   

   public abstract void Cook();

}