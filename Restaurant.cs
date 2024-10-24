using System.Globalization;
using System.Text;

namespace TheRestaurant;

public class Restaurant 
{
    //private List<Order> orders = [];
    private static readonly Queue<Order> OrdersQueue = new();
    private static readonly List<Order> OrdersCooked = [];

    public static async Task AddOrder(Order order)
    {
        //orders.Add(order);
        OrdersQueue.Enqueue(order);
        //await Task.Run(() => CookAndServe(order));
        await Task.Run(() => ProcessQueue(order));

    }

    public static async Task ProcessQueue(Order order)
    {
        OrdersCooked.Add(OrdersQueue.Dequeue());
        Thread.Sleep(3000);
        //var orders = ordersQueue.ToArray();
        await Task.Run(() => CookAndServe(order));
    }

    public static int OrderTaken(Restaurant order)
    {
        var count = OrdersQueue.Count;
        return count;
    }
    
    private static async Task CookAndServe(Order order)
    {
        order.Cook();
        await Task.Delay(order.CookingTime);
        Console.WriteLine($"{order.DishName} is cooked!");
    }

    public static int OrderDelivered(Restaurant order)
    {
       var count = OrdersCooked.Count;
       return count;
    }
    
}