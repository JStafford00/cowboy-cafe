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
                            var entree = new CowpokeChili();
                            var screen = new CustomizeCowpokeChili();
                            screen.DataContext = entree;
                            order.Add(entree);
                            orderControl.SwapScreen(screen);
                            break;

                        case "Rustler's Ribs":
                            order.Add(new RustlersRibs());
                            break;

                        case "Pecos Pulled Pork":
                            order.Add(new PecosPulledPork());
                            break;

                        case "Trail Burger":
                            order.Add(new TrailBurger());
                            break;

                        case "Dakota Double Burger":
                            order.Add(new DakotaDoubleBurger());
                            break;

                        case "Texas Triple Burger":
                            order.Add(new TexasTripleBurger());
                            break;

                        case "Angry Chicken":
                            order.Add(new AngryChicken());
                            break;

                        case "Chili Cheese Fries":
                            order.Add(new ChiliCheeseFries());
                            break;

                        case "Corn Dodgers":
                            order.Add(new CornDodgers());
                            break;

                        case "Pan De Campo":
                            order.Add(new PanDeCampo());
                            break;

                        case "Baked Beans":
                            order.Add(new BakedBeans());
                            break;

                        case "Jerked Soda":
                            order.Add(new JerkedSoda());
                            break;

                        case "Texas Tea":
                            order.Add(new TexasTea());
                            break;

                        case "Cowboy Coffee":
                            order.Add(new CowboyCoffee());
                            break;

                        case "Water":
                            order.Add(new Water());
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

            // Not all OrderItems need to be customized
            if (screen != null)
            {
                // We need to have OrderControl ancestor to load the cusomization screen
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null)
                    throw new Exception("An ancestor of OrderControl expected, instead was null");

                orderControl.SwapScreen(screen);
            }

            // Add this item to the order.
            order.Add(item);
        }
    }
}
