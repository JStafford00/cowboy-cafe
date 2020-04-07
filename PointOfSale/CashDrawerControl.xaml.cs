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
using CowboyCafe.Extensions;
using CowboyCafe.Data;

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
            if(DataContext is CashRegisterModelView data)
            {
                if(data.AmountNeeded > -0.01 && data.AmountNeeded < 0.01)
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
