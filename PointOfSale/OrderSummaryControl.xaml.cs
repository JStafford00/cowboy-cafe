using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if(DataContext is Order data)
            {
                if(sender is Button button)
                {
                    data.Remove((IOrderItem)button.DataContext);
                }
            }
        }

        private void OrderDisplayClick(object sender, SelectionChangedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if(sender is ListBox list)
            {
                if(list.SelectedItem is IOrderItem item)
                {
                    switch(item.ItemType)
                    {
                        case "Angry Chicken":
                            var screenAC = new CustomizeAngryChicken();
                            screenAC.DataContext = item;
                            orderControl.SwapScreen(screenAC);
                            break;
                        case "Cowpoke Chili":
                            var screenCC = new CustomizeCowpokeChili();
                            screenCC.DataContext = item;
                            orderControl.SwapScreen(screenCC);
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }

        void OpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            // We need to have an Order to add this item
            var order = DataContext as Order;
            if(order == null)
                throw new Exception("DataContext expected to be Order, instead was null");

            screen.DataContext = item;

            // Add this item to the order.
            order.Add(item);

            // Not all OrderItems need to be customized
            if(screen != null)
            {
                // We need to have OrderControl ancestor to load the cusomization screen
                var orderControl = this.FindAncestor<OrderControl>();
                if(orderControl == null)
                    throw new Exception("An ancestor of OrderControl expected, instead was null");

                orderControl.SwapScreen(screen);
            }
        }
    }
}
