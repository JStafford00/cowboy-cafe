﻿using CowboyCafe.Data;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeBakedBeans.xaml
    /// </summary>
    public partial class CustomizeBakedBeans : UserControl
    {
        public CustomizeBakedBeans()
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
            if (DataContext is BakedBeans side)
            {
                if (sender is RadioButton button)
                {
                    switch (button.Tag)
                    {
                        case "Small":
                            side.Size = CowboyCafe.Data.Size.Small;
                            break;
                        case "Medium":
                            side.Size = CowboyCafe.Data.Size.Medium;
                            break;
                        case "Large":
                            side.Size = CowboyCafe.Data.Size.Large;
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }
    }
}
