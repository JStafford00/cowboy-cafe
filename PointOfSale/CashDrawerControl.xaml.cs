using CowboyCafe.Extensions;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashDrawerControl.xaml
    /// </summary>
    public partial class CashDrawerControl : UserControl
    {

        public CashDrawerControl()
        {
            InitializeComponent();
            this.DataContext = new CashRegisterModelView();
        }

        private void CompleteTransactionButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashRegisterModelView data)
            {
                if (data.AmountNeeded > -0.01 && data.AmountNeeded < 0.01)
                {
                    var orderControl = new OrderControl();

                    var mainWindow = this.FindAncestor<MainWindow>();
                    mainWindow.SwapScreenMain(orderControl);
                }

                else
                {
                    ErrorMSG.Text = "Transaction not complete. Amount Needed must equal zero.";
                }
            }

        }
    }
}
