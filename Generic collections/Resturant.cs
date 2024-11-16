using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_collections
{
    internal class Resturant
    {
        List<MenuItem> _menu = new List<MenuItem>();
        Queue<Order> _orderQueue = new Queue<Order>();

        // AddToMenu Method
        public void AddtoMenu(MenuItem menuItem)
        {
            _menu.Add(menuItem);
            Console.WriteLine($"{menuItem.Name} dish added to the menu.");
        }

        // ShowMenu Method
        public void ShowMenu()
        {
            foreach(var item in _menu)
            {
                Console.WriteLine(item);
            }
        }

        // CreateOrder Method
        public void CreateOrder(Order order)
        {
            _orderQueue.Enqueue(order);
            Console.WriteLine($"Order number {order._orderId} placed for table number {order._tableNumber}.");
        }

        // HandleOrder Method
        public void HandleOrder()
        {
            var handledOrder = _orderQueue.Dequeue();
            Console.WriteLine($"Order {handledOrder._orderId} handled for table {handledOrder._tableNumber}");
        }

        public void ShowOrders()
        {
            foreach (var item in _orderQueue)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowNextOrder()
        {
            var nextOrder = _orderQueue.Peek();
            Console.WriteLine(nextOrder);
        }

        public void ShowOrderCount()
        {
            if (_orderQueue.Count > 0)
            {
                Console.WriteLine($"There are {_orderQueue.Count} orders in the queue\n");
            }
            else
            {
                Console.WriteLine("There are no more orders in queue atm");
            }

        }
    }


}
