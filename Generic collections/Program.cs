using static System.Net.Mime.MediaTypeNames;

namespace Generic_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boring line
            string lines = "--------------------";

            // Constructor
            Resturant resturant = new Resturant();

            // Dish
            resturant.AddtoMenu(new MenuItem(1, "Pizza", 99.90m));
            resturant.AddtoMenu(new MenuItem(2, "Hamburger", 79.90m));
            resturant.AddtoMenu(new MenuItem(3, "Pasta", 89.90m));
            resturant.AddtoMenu(new MenuItem(4, "Tacos", 79.90m));

            // Create Orders

            // Order 1
            Order order1 = new Order(new List<MenuItem>(), 4);
            order1.AddDish(new MenuItem(1, "Pizza", 99.90m));
            order1.AddDish(new MenuItem(2, "Hamburger", 79.90m));


            // Order 2
            Order order2 = new Order(new List<MenuItem>(), 6);
            order2.AddDish(new MenuItem(2, "Hamburger", 79.90m));
            order2.AddDish(new MenuItem(3, "Pasta", 89.90m));

            // Order 3
            Order order3 = new Order(new List<MenuItem>(), 12);
            order3.AddDish(new MenuItem(3, "Pasta", 89.90m));
            order3.AddDish(new MenuItem(4, "Tacos", 79.90m));



            // Show Menu
            Console.WriteLine($"{lines}\nMenu:");
            resturant.ShowMenu();

            // Show Order Confirmation
            Console.WriteLine($"{lines}");
            resturant.CreateOrder(order1);
            resturant.CreateOrder(order2);
            resturant.CreateOrder(order3);

            // Show Orders
            Console.WriteLine($"{lines}");
            resturant.ShowOrders();

            // Show Order Count
            Console.WriteLine(lines);
            resturant.ShowOrderCount();

            // Show Next Order
            Console.WriteLine("Next order in queue:");
            resturant.ShowNextOrder();

            // Show HandleOrder
            resturant.HandleOrder();

            // Show Order Count
            Console.WriteLine();
            resturant.ShowOrderCount();
            Console.WriteLine(lines);

            // Order 4 + Show Confirmation
            Order order4 = new Order(new List<MenuItem>(), 16);
            order4.AddDish(new MenuItem(1, "Pizza", 99.90m));
            order4.AddDish(new MenuItem(4, "Tacos", 79.90m));
            resturant.CreateOrder(order4);

            // Show Order Count
            Console.WriteLine( );
            resturant.ShowOrderCount();

            // Show HandleOrder 2x
            resturant.HandleOrder();
            resturant.HandleOrder();

            // Show Order Count
            Console.WriteLine();
            resturant.ShowOrderCount();

            // Show Next Order
            Console.WriteLine($"{lines}\nNext order in queue:");
            resturant.ShowNextOrder();

            // Show HandleOrder
            resturant.HandleOrder();

            // Show Order Count
            Console.WriteLine();
            resturant.ShowOrderCount();
        }
    }
}
