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

namespace PointOfSale
{
    /*
     * Author: Jordan Stafford
     * Class: OrderControl
     * Purpose: User Control for Complete Order, Cancel Order, and Item Selection buttons
     */
    public partial class OrderControl : UserControl
    {
        
        /// <summary>
        /// Initializes Component
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            this.DataContext = new Order();

        }

        /// <summary>
        /// Click action for ItemSelectionButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// Click action for CancelOrderButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// Click action for CompleteOrderButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }
    }
}
