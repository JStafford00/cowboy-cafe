using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order
    {
        private static uint lastOrderNumber;

        private List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items { get { return items; } }

        public event PropertyChangedEventHandler PropertyChanged;

        public double Subtotal
        {
            get
            {
                double subtotal = 0;

                foreach (IOrderItem item in items)
                {
                    subtotal += item.Price;
                }

                return subtotal;
            }
        }

        private uint OrderNumber
        {
            get
            {
                return lastOrderNumber + 1;
            }
        }

        public void Add(IOrderItem item)
        {
            items.Add(item);
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
        }
    }
}
