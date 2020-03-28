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
    /*
     * Author: Jordan Stafford
     * Class: MenuItemSelectionControl
     * Purpose: All the buttons for adding items to the order.
     */
    public partial class MenuItemSelectionControl : UserControl
    {

        /// <summary>
        /// Initializes MenuItemSelectionControl
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {

            var orderControl = this.FindAncestor<OrderControl>();

            if(DataContext is Order order)
            {

                if (sender is Button button)
                {
                    switch (button.Tag)
                    {

                        case "Cowpoke Chili":
                            AddItemAndOpenCusomizationScreen(new CowpokeChili(), new CustomizeCowpokeChili());
                            break;

                        case "Rustler's Ribs":
                            order.Add(new RustlersRibs());
                            break;

                        case "Pecos Pulled Pork":
                            AddItemAndOpenCusomizationScreen(new PecosPulledPork(), new CustomizePecosPulledPork());
                            break;

                        case "Trail Burger":
                            AddItemAndOpenCusomizationScreen(new TrailBurger(), new CustomizeTrailBurger());
                            break;

                        case "Dakota Double Burger":
                            AddItemAndOpenCusomizationScreen(new DakotaDoubleBurger(), new CustomizeDakotaDoubleBurger());
                            break;

                        case "Texas Triple Burger":
                            AddItemAndOpenCusomizationScreen(new TexasTripleBurger(), new CustomizeTexasTripleBurger());
                            break;

                        case "Angry Chicken":
                            AddItemAndOpenCusomizationScreen(new AngryChicken(), new CustomizeAngryChicken());
                            break;

                        case "Chili Cheese Fries":
                            AddItemAndOpenCusomizationScreen(new ChiliCheeseFries(), new CustomizeChiliCheeseFries());
                            break;

                        case "Corn Dodgers":
                            AddItemAndOpenCusomizationScreen(new CornDodgers(), new CustomizeCornDodgers());
                            break;

                        case "Pan De Campo":
                            AddItemAndOpenCusomizationScreen(new PanDeCampo(), new CustomizePanDeCampo());
                            break;

                        case "Baked Beans":
                            AddItemAndOpenCusomizationScreen(new BakedBeans(), new CustomizeBakedBeans());
                            break;

                        case "Jerked Soda":
                            AddItemAndOpenCusomizationScreen(new JerkedSoda(), new CustomizeJerkedSoda());
                            break;

                        case "Texas Tea":
                            AddItemAndOpenCusomizationScreen(new TexasTea(), new CustomizeTexasTea());
                            break;

                        case "Cowboy Coffee":
                            AddItemAndOpenCusomizationScreen(new CowboyCoffee(), new CustomizeCowboyCoffee());
                            break;

                        case "Water":
                            AddItemAndOpenCusomizationScreen(new Water(), new CustomizeWater());
                            break;

                        default:
                            throw new NotImplementedException();
                    }
                }
            }
            
        }

        void AddItemAndOpenCusomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            // We need to have an Order to add this item
            var order = DataContext as Order;
            if (order == null)
                throw new Exception("DataContext expected to be Order, instead was null");

            screen.DataContext = item;

            // Add this item to the order.
            order.Add(item);

            // Not all OrderItems need to be customized
            if (screen != null)
            {
                // We need to have OrderControl ancestor to load the cusomization screen
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null)
                    throw new Exception("An ancestor of OrderControl expected, instead was null");

                orderControl.SwapScreen(screen);
            }
        }
    }
}
