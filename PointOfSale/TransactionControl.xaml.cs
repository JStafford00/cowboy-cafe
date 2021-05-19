using CashRegister;
using CowboyCafe.Data;
using CowboyCafe.Extensions;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {

        public TransactionControl()
        {
            InitializeComponent();
        }

        private string cardStatus = "";

        private void CreditButtonClick(object sender, RoutedEventArgs e)
        {
            var card = new CardTerminal();

            if (DataContext is Order data)
            {
                ResultCode result = card.ProcessTransaction(data.Total);

                switch (result)
                {
                    case ResultCode.Success:
                        ReceiptPrinter receiptPrinter = new ReceiptPrinter();

                        var orderControl = new OrderControl();

                        var mainWindow = this.FindAncestor<MainWindow>();
                        mainWindow.SwapScreenMain(orderControl);

                        ReceiptPrinter print = new ReceiptPrinter();

                        print.Print(data.OrderNumber.ToString());
                        print.Print(DateTime.Now.ToString());
                        foreach (IOrderItem item in data.Items)
                        {
                            print.Print(item.ToString() + " : " + item.Price.ToString());
                            print.Print(item.SpecialInstructions.ToString());
                        }

                        print.Print(data.Total.ToString());
                        break;

                    case ResultCode.InsufficentFunds:
                        cardStatus = "Insufficent Funds";
                        break;

                    case ResultCode.ReadError:
                        cardStatus = "Read Error";
                        break;

                    case ResultCode.UnknownErrror:
                        cardStatus = "Unknown Error";
                        break;
                }

                CardStatus.Text = cardStatus;
            }



        }

        private void CashButtonClick(object sender, RoutedEventArgs e)
        {
            CashDrawerControl screen = new CashDrawerControl();
            if (DataContext is Order order)
            {
                if (screen.DataContext is CashRegisterModelView data)
                {
                    data.AmountNeeded = order.Total;
                }
            }
            Display.Child = screen;
        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = new OrderControl();

            var mainWindow = this.FindAncestor<MainWindow>();
            mainWindow.SwapScreenMain(orderControl);
        }
    }
}
