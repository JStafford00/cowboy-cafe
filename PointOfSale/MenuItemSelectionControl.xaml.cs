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
                            var entreeCC = new CowpokeChili();
                            var screenCC = new CustomizeCowpokeChili();
                            screenCC.DataContext = entreeCC;
                            order.Add(entreeCC);
                            orderControl.SwapScreen(screenCC);
                            break;

                        case "Rustler's Ribs":
                            order.Add(new RustlersRibs());
                            break;

                        case "Pecos Pulled Pork":
                            var entreePP = new PecosPulledPork();
                            var screenPP = new CustomizePecosPulledPork();
                            screenPP.DataContext = entreePP;
                            order.Add(entreePP);
                            orderControl.SwapScreen(screenPP);
                            break;

                        case "Trail Burger":
                            var entreeTB = new TrailBurger();
                            var screenTB = new CustomizeTrailBurger();
                            screenTB.DataContext = entreeTB;
                            order.Add(entreeTB);
                            orderControl.SwapScreen(screenTB);
                            break;

                        case "Dakota Double Burger":
                            var entreeDD = new DakotaDoubleBurger();
                            var screenDD = new CustomizeDakotaDoubleBurger();
                            screenDD.DataContext = entreeDD;
                            order.Add(entreeDD);
                            orderControl.SwapScreen(screenDD);
                            break;

                        case "Texas Triple Burger":
                            var entreeTTB = new DakotaDoubleBurger();
                            var screenTTB = new CustomizeDakotaDoubleBurger();
                            screenTTB.DataContext = entreeTTB;
                            order.Add(entreeTTB);
                            orderControl.SwapScreen(screenTTB);
                            break;

                        case "Angry Chicken":
                            var entreeAC = new AngryChicken();
                            var screenAC = new CustomizeAngryChicken();
                            screenAC.DataContext = entreeAC;
                            order.Add(entreeAC);
                            orderControl.SwapScreen(screenAC);
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
                            var drinkJS = new JerkedSoda();
                            var screenJS = new CustomizeJerkedSoda();
                            screenJS.DataContext = drinkJS;
                            order.Add(drinkJS);
                            orderControl.SwapScreen(screenJS);
                            break;

                        case "Texas Tea":
                            var drinkTT = new TexasTea();
                            var screenTT = new CustomizeTexasTea();
                            screenTT.DataContext = drinkTT;
                            order.Add(drinkTT);
                            orderControl.SwapScreen(screenTT);
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
