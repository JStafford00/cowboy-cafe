﻿using System;
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
using CashRegister;
using CowboyCafe.Data;
using CowboyCafe.Extensions;

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

            if(DataContext is Order data)
            {
                ResultCode result = card.ProcessTransaction(data.Total);

                switch(result)
                {
                    case ResultCode.Success:
                        ReceiptPrinter receiptPrinter = new ReceiptPrinter();

                        var orderControl = new OrderControl();

                        var mainWindow = this.FindAncestor<MainWindow>();
                        mainWindow.SwapScreenMain(orderControl);
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
            if(DataContext is Order order)
            {
                if(screen.DataContext is CashRegisterModelView data)
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
