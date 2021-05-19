using CowboyCafe.Data;
using CowboyCafe.Extensions;
using System;
using System.Windows;
using System.Windows.Controls;

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

        /// <summary>
        /// Click event for remove item button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">Event Args</param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    data.Remove((IOrderItem)button.DataContext);
                }
            }
        }

        /// <summary>
        /// Click event for an order item in the order menu
        /// </summary>
        /// <param name="sender">Order item being selected</param>
        /// <param name="e">Selection event args</param>
        private void OrderDisplayClick(object sender, SelectionChangedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (sender is ListBox list)
            {
                if (list.SelectedItem is IOrderItem item)
                {
                    switch (item.ItemType)
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

        /// <summary>
        /// Opens the Customization screen
        /// </summary>
        /// <param name="item">Order Item being accessed</param>
        /// <param name="screen">Screen being opened</param>
        private void OpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            // Not all OrderItems need to be customized
            if (screen != null)
            {
                // We need to have OrderControl ancestor to load the cusomization screen
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null)
                    throw new Exception("An ancestor of OrderControl expected, instead was null");

                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }
        }
    }
}
