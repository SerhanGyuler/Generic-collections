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
            resturant.AddtoMenu(new MenuItem(1, "Hamburger", 79.90m));
            resturant.AddtoMenu(new MenuItem(1, "Pasta", 89.90m));
            resturant.AddtoMenu(new MenuItem(1, "Tacos", 79.90m));

            // Create Orders
            

            // Show Menu
            Console.WriteLine($"{lines}\nMenu:");
            resturant.ShowMenu();
            
        }
    }
}
