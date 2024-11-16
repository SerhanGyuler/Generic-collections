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

        public void AddtoMenu(MenuItem menuItem)
        {
            _menu.Add(menuItem);
            Console.WriteLine($"Maträtt {menuItem.Name} lades till i menyn");
        }

        public void ShowMenu()
        {
            foreach(var item in _menu)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }


}
