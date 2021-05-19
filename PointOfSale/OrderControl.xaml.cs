using CowboyCafe.Data;
using CowboyCafe.Extensions;
using System.Windows;
using System.Windows.Controls;

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
            var trans = new TransactionControl();
            trans.DataContext = this.DataContext;

            var mainWindow = this.FindAncestor<MainWindow>();
            mainWindow.SwapScreenMain(trans);
        }

        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }
    }
}
