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
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
            
        }

        /// <summary>
        /// Click action for Cowpoke Chili button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       /* private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            var entree = new CowpokeChili();

            if(DataContext is Order data)
            {
                data.Add(entree);
                orderControl.SwapScreen(new CustomizeCowpokeChili());
            }
            
        }
        */

        /// <summary>
        /// Click action for Chili Cheese Fries button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            var side = new ChiliCheeseFries();

            if(DataContext is Order data)
            {
                data.Add(side);
            }
        }

        /// <summary>
        /// Click action for Corn Dodgers button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            var side = new CornDodgers();

            if(DataContext is Order data)
            {
                data.Add(side);
            }
        }

        /// <summary>
        /// Click action for Pan De Campo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            var side = new PanDeCampo();

            if(DataContext is Order data)
            {
                data.Add(side);
            }
        }

        /// <summary>
        /// Click action for Baked Beans button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            var side = new BakedBeans();

            if(DataContext is Order data)
            {
                data.Add(side);
            }
        }

        /// <summary>
        /// Click action for Jerked Sods button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            var drink = new JerkedSoda();

            if(DataContext is Order data)
            {
                data.Add(drink);
            }
        }

        /// <summary>
        /// Click action for Texas Tea button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            var drink = new TexasTea();

            if(DataContext is Order data)
            {
                data.Add(drink);
            }
        }

        /// <summary>
        /// Click action for Cowboy Coffee button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            var drink = new CowboyCoffee();

            if(DataContext is Order data)
            {
                data.Add(drink);
            }
        }

        /// <summary>
        /// Click action for water button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            var drink = new Water();

            if(DataContext is Order data)
            {
                data.Add(drink);
            }
        }
    }
}
