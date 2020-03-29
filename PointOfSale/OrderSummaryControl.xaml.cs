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
                            OpenCustomizationScreen(item, new CustomizeAngryChicken());
                            break;
                        case "Cowpoke Chili":
                            OpenCustomizationScreen(item, new CustomizeCowpokeChili());
                            break;
                        case "Pecos Pulled Pork":
                            OpenCustomizationScreen(item, new CustomizePecosPulledPork());
                            break;
                        case "Trail Burger":
                            OpenCustomizationScreen(item, new CustomizeTrailBurger());
                            break;
                        case "Dakota Double Burger":
                            OpenCustomizationScreen(item, new CustomizeDakotaDoubleBurger());
                            break;
                        case "Texas Triple Burger":
                            OpenCustomizationScreen(item, new CustomizeTexasTripleBurger());
                            break;
                        case "Chili Cheese Fries":
                            OpenCustomizationScreen(item, new CustomizeChiliCheeseFries());
                            break;
                        case "Corn Dodgers":
                            OpenCustomizationScreen(item, new CustomizeCornDodgers());
                            break;
                        case "Pan de Campo":
                            OpenCustomizationScreen(item, new CustomizePanDeCampo());
                            break;
                        case "Baked Beans":
                            OpenCustomizationScreen(item, new CustomizeBakedBeans());
                            break;
                        case "Jerked Soda":
                            OpenCustomizationScreen(item, new CustomizeJerkedSoda());
                            break;
                        case "Texas Tea":
                            OpenCustomizationScreen(item, new CustomizeTexasTea());
                            break;
                        case "Cowboy Coffee":
                            OpenCustomizationScreen(item, new CustomizeCowboyCoffee());
                            break;
                        case "Water":
                            OpenCustomizationScreen(item, new CustomizeWater());
                            break;
                        case "Rustlers Ribs":
                            break;
                        default:
                            throw new NotImplementedException();
                    }

                    list.SelectedItem = null;
                }
            }
        }

        void OpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            // Not all OrderItems need to be customized
            if(screen != null)
            {
                // We need to have OrderControl ancestor to load the cusomization screen
                var orderControl = this.FindAncestor<OrderControl>();
                if(orderControl == null)
                    throw new Exception("An ancestor of OrderControl expected, instead was null");

                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }
        }
    }
}
