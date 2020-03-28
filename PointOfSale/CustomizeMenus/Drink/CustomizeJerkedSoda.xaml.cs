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
using CowboyCafe;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeJerkedSoda.xaml
    /// </summary>
    public partial class CustomizeJerkedSoda : UserControl
    {
        public CustomizeJerkedSoda()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Flavor Radio Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlavorRadioButtonClick(object sender, RoutedEventArgs e)
        {
            if(DataContext is JerkedSoda drink)
            {
                if(sender is RadioButton button)
                {
                    switch(button.Tag)
                    {
                        case "Cream Soda":
                            drink.Flavor = SodaFlavor.CreamSoda;
                            break;
                        case "Orange Soda":
                            drink.Flavor = SodaFlavor.OrangeSoda;
                            break;
                        case "Sarsparilla":
                            drink.Flavor = SodaFlavor.Sarsparilla;
                            break;
                        case "Birch Beer":
                            drink.Flavor = SodaFlavor.BirchBeer;
                            break;
                        case "Root Beer":
                            drink.Flavor = SodaFlavor.RootBeer;
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }

        /// <summary>
        /// Size Radio Button Click
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e"></param>
        private void RadioButtonClick(object sender, RoutedEventArgs e)
        {
            if(DataContext is JerkedSoda drink)
            {
                if(sender is RadioButton button)
                {
                    switch(button.Tag)
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
