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

        public event PropertyChangedEventHandler PropertyChanged;

        public IEnumerable<IOrderItem> Items => items.ToArray();

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
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
