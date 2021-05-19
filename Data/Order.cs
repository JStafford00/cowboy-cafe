using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /*
     * Author: Jordan Stafford
     * Class: Order
     * Purpose: Order object class
     */
    public class Order : INotifyPropertyChanged
    {
        private static uint lastOrderNumber = 0;

        private List<IOrderItem> items = new List<IOrderItem>();

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Build a new order.
        /// </summary>
        public Order()
        {
            lastOrderNumber++;
        }

        /// <summary>
        /// Turns items into an array.
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// The total price of all items before tax.
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0.0;

                foreach (IOrderItem item in Items)
                {
                    subtotal += item.Price;
                }

                return subtotal;
            }
        }

        /// <summary>
        /// The total price of all items after tax.
        /// </summary>
        public double Total
        {
            get
            {
                double total = 0.0;

                foreach (IOrderItem item in Items)
                {
                    total += item.Price;
                }

                return total * 1.16;
            }
        }

        /// <summary>
        /// The current order number
        /// </summary>
        public uint OrderNumber
        {
            get
            {
                return lastOrderNumber;
            }
        }

        /// <summary>
        /// Adds an item to the list
        /// </summary>
        /// <param name="item">Item being added</param>
        public void Add(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifier)
                notifier.PropertyChanged += OnItemPropertyChange;

            items.Add(item);

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Removes items from the list
        /// </summary>
        /// <param name="item">Item being removed</param>
        public void Remove(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifier)
                notifier.PropertyChanged -= OnItemPropertyChange;

            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Event listener
        /// </summary>
        private void OnItemPropertyChange(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));

            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }
    }
}
