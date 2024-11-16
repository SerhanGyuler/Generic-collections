using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_collections
{
    internal class Order
    {
        // In this class, we use private fields instead.
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatic generation of IDs
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }
    }
}
