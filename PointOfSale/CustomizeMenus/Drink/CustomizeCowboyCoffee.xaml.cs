using CowboyCafe.Data;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCowboyCoffee.xaml
    /// </summary>
    public partial class CustomizeCowboyCoffee : UserControl
    {
        public CustomizeCowboyCoffee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Size Radio Button Click
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e"></param>
        private void RadioButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowboyCoffee drink)
            {
                if (sender is RadioButton button)
                {
                    switch (button.Tag)
                    {
                        case "Small":
                            drink.Size = CowboyCafe.Data.Size.Small;
                            break;
                        case "Medium":
                            drink.Size = CowboyCafe.Data.Size.Medium;
                            break;
                        case "Large":
                            drink.Size = CowboyCafe.Data.Size.Large;
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }
    }
}
