using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Generic_collections
{
    internal class Order
    {
        // In this class, we use private fields instead.
        static int orderIdCounter = 1;
        public int _orderId;
        private List<MenuItem> _orderItems;
        public int _tableNumber;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatic generation of IDs
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }
        public void AddDish(MenuItem item)
        {
            _orderItems.Add(item);
        }
        public override string ToString()
        {
            // .Select selects desired item in a list
            string items = string.Join("\n", _orderItems.Select(item => $"{item.Id} st {item.Name}"));
            // Sum sums ints
            decimal totalprice = _orderItems.Sum(item => item.Price);
            return $"Order {_orderId}\n{items}\nTotal price: {totalprice.ToString("C")}\nTo Table Number: {_tableNumber}\n";
            
        }
    }
}

