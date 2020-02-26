using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order : IOrderItem
    {
        private uint lastOrderNumber;

        private List<IOrderItem> items;

        private IEnumerable<IOrderItem> Items { get { return items; } }

        public double Subtotal { get; } = 0;

        public double Price => throw new NotImplementedException();

        public IEnumerable<string> SpecialInstructions => throw new NotImplementedException();

        public void Add(IOrderItem item)
        {
            
        }

        public void Remove(IOrderItem item)
        {

        }
    }
}
